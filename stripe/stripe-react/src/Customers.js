import React, { useState, useEffect, Suspense } from 'react';
import { fetchFromAPI } from './helpers';
import { CardElement, useStripe, useElements } from '@stripe/react-stripe-js'
import { useUser, AuthCheck } from 'reactfire';

import firebase from 'firebase/app';
import { auth, db } from './firebase';

export default function Customers() {
  return (
    <Suspense fallback={'loading user'}>
      <SaveCard />
    </Suspense>
  );
}

function SaveCard(props) {
  const stripe = useStripe();
  const elements = useElements();
  const user = useUser();

  const [setupIntent, setSetupIntent] = useState();
  const [wallet, setWallet] = useState([]);

  useEffect(() => {
    getWallet();
  }, [user]); // only runs when component is first mounted as array is specified or when user data changes

  const createSetupIntent = async (event) => {
    const si = await fetchFromAPI('wallet');
    setSetupIntent(si);
  };

  const handleSubmit = async (event) => {
    event.preventDefault();

    const cardElement = elements.getElement(CardElement);

    const {
      setupIntent: updateSetupIntent,
      error
    } = await stripe.confirmCardSetup(
      setupIntent.client_secret, {
        payment_method: { card: cardElement }
    });

    if (error) {
      alert(error.message);
      console.log(error);
    } else {
      setSetupIntent(updateSetupIntent);
      await getWallet();
      alert('Success! Card added to your wallet');
    }
  }

  const getWallet = async () => {
    if (user) {
      const paymentMethods = await fetchFromAPI('wallet', {
        method: 'GET'
      });
      setWallet(paymentMethods);
    }
  };

  return (
    <>
      <AuthCheck fallback={<SignIn />}>

        <div>
          <button
            onClick={createSetupIntent}>
            Attach New Credit Card
          </button>
        </div>

        <form onSubmit={handleSubmit}>
          <CardElement />
          <button type="submit">
            Attach
          </button>
        </form>

        <select>
          {wallet.map((paymentSource) => (
            <CreditCard key={paymentSource.id} card={paymentSource.card}/>
          ))}
        </select>

        <div>
          <SignOut user={user} />
        </div>

      </AuthCheck>
    </>
  )
}

function CreditCard(props) {
  const { last4, brand, exp_month, exp_year } = props.card;
  return (
    <option>
      {brand} **** **** **** {last4} expires {exp_month}/{exp_year}
    </option>
  )
}

export function SignIn() {
  const signIn = async () => {
    const credential = await auth.signInWithPopup(
      new firebase.auth.GoogleAuthProvider()
    );
    const { uid, email } = credential.user;
    db.collection('users').doc(uid).set({ email }, { merge: true });
  };

  return (
    <button onClick={signIn}>
      Sign In with Google
    </button>
  )
}

export function SignOut(props) {
  return props.user && (
    <button onClick={() => auth.signOut()}>
      Sign Out User {props.user.uid}
    </button>
  )
}