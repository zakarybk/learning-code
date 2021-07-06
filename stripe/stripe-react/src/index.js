import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';

import { Elements } from '@stripe/react-stripe-js';
import { loadStripe } from '@stripe/stripe-js'

import { FirebaseAppProvider } from 'reactfire';

export const stripePromise = loadStripe(
  'pk_test_51IblHxJv2DFOpt5zDPKDVbX1YWd3GbArrC9EZaYdY5KBMXuubLM69Ssz65JIHeQjfxRVzweCgBiHW9Lo8UcvaiJk000svRr3qT'
)

export const firebaseConfig = {
  apiKey: "AIzaSyAdeCakLlAlmLVG7Grf9hcoJjXCXgaL-Q8",
  authDomain: "stripe-82069.firebaseapp.com",
  projectId: "stripe-82069",
  storageBucket: "stripe-82069.appspot.com",
  messagingSenderId: "913854342461",
  appId: "1:913854342461:web:74d455e90dd3ab71dd9154"
};

ReactDOM.render(
  <React.StrictMode>
    <FirebaseAppProvider firebaseConfig={firebaseConfig}>
      <Elements stripe={stripePromise}>
        <App />
      </Elements>
    </FirebaseAppProvider>
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
