import React, { useState, useEffect, Suspense } from 'react';
import { fetchFromAPI } from './helpers';
import { CardElement, useStripe, useElements } from '@stripe/react-stripe-js';
import { useUser, AuthCheck } from 'reactfire';

import { db } from './firebase';
import { SignIn, SignOut } from './Customers';

function UserData(props) {
  const [data, setData] = useState({});

  useEffect(
    () => {
      const unsubscribe = db
        .collection('users')
        .doc(props.user.uid)
        .onSnapshot(doc => setData(doc.data()))
      return unsubscribe;
    },
    [props.user]
  )

  return (
    <pre>
      Stripe Customer ID: {data.stripeCustomerID} <br />
      Subscriptions: {JSON.stringify(data.activePlans || [])}
    </pre>
  );
}

export default function SubscribeToPlan(props) {
  const stripe = useStripe();
  const elements = useElements();
  const user = useUser();

  const [plan, setPlan] = useState();
  const [subscriptions, setSubscriptions] = useState([]);
  const [loading, setLoading] = useState(false);
  const [loadedUser, setLoadedUser] = useState(false);

  useEffect(() => {
    if (!loadedUser) // prevent it calling Firestore every second
      getSubscriptions();
  }, [user]);

  const getSubscriptions = async () => {
    if (user) {
      const subs = await fetchFromAPI('subscriptions', { method: 'GET' });
      setSubscriptions(subs);
      setLoadedUser(true);
    }
  };

  const cancel = async (id) => {
    setLoading(true);
    await fetchFromAPI('subscriptions/' + id, { method: 'PATCH' });
    alert('Cancelled');
    await getSubscriptions();
    setLoading(false);
  }

  const handleSubmit = async (event) => {
    setLoading(true);
    event.preventDefault();

    const cardElement = elements.getElement(CardElement);

    const { paymentMethod, error } = await stripe.createPaymentMethod({
      type: 'card',
      card: cardElement
    });

    if (error) {
      alert(error.message);
      setLoading(false);
      return;
    }

    const subscription = await fetchFromAPI('subscriptions', {
      body: {
        plan,
        payment_method: paymentMethod.id
      }
    });

    const { latest_invoice } = subscription;

    // extra auth with bank
    if (latest_invoice.payment_intent) {
      const { client_secret, status } = latest_invoice.payment_intent;

      if (status === 'requires_action') {
        const { error: confirmationError } = await stripe.confirmCardPayment(
          client_secret
        )
        if (confirmationError) {
          console.error(confirmationError);
          alert('Unable to confirm card');
          return;
        }
      }

      alert('You have been subscribed!');
      getSubscriptions();
    }

    setLoading(false);
    setPlan(null);
  }

  return (
    <>
      <AuthCheck fallback={<SignIn />}>

        <div>
          <button
            onClick={() => setPlan('price_1Ibq2TJv2DFOpt5zgKWg8K0F')}>
            Choose Monthly £5/yr
          </button>

          <button
            onClick={() => setPlan('price_1IcXvLJv2DFOpt5zEtrlyYS6')}>
            Choose Yearly £50/yr
          </button>

          <p>
            Selected Plan: <strong>{plan}</strong>
          </p>
        </div>

        <form onSubmit={handleSubmit} hidden={!plan}>
          <CardElement />
          <button type="submit" disabled={loading}>
            Subscribe & Pay
          </button>
        </form>

        {subscriptions.map((sub) => (
          <div key={sub.id}>
            {sub.id}. Next payment of {sub.plan.amount} due{' '}
            {new Date(sub.current_period_end * 1000).toUTCString()}
            <button
              onClick={() => cancel(sub.id)}
              disabled={loading}>
                Cancel
            </button>
          </div>
        ))}

        <div>
          <SignOut user={user} />
        </div>
      </AuthCheck>
    </>
  );
}