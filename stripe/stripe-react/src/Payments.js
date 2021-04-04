import React, { useState } from 'react';
import { fetchFromAPI } from './helpers';
import { CardElement, useStripe, useElements } from '@stripe/react-stripe-js';

export default function Payments() {
    const stripe = useStripe();
    const elements = useElements();

    const [amount, setAmount] = useState(0);
    const [paymentIntent, setPaymentIntent] = useState();

    const createPaymentIntent = async(event) => {
        const validAmount = Math.min(Math.max(amount, 50), 99999999);
        setAmount(validAmount);

        const pi = await fetchFromAPI('payments', { body: { amount: validAmount }});
        setPaymentIntent(pi);
    };

    const handleSubmit = async (event) => {
        // prevent browser re-direct
        event.preventDefault();

        const cardElement = elements.getElement(CardElement);

        // confirm card payment
        const {
            paymentIntent: updatePaymentIntent,
            error
        } = await stripe.confirmCardPayment(paymentIntent.client_secret, {
            payment_method: { card: cardElement }
        });

        if (error) {
            console.error(error);
            error.payment_intent && setPaymentIntent(error.payment_intent);
        } else {
            setPaymentIntent(updatePaymentIntent);
        }
    };

    return (
        <>
            <div>
                <input
                    type="number"
                    value={amount}
                    disabled={paymentIntent}
                    onChange={(e) => setAmount(e.target.value)}
                />
                <button
                    disabled={amount <= 0}
                    onClick={createPaymentIntent}
                    hidden={paymentIntent}>
                    Ready to Pay £{ (amount / 100).toFixed(2) }
                </button>

                <form onSubmit={handleSubmit}>
                    <CardElement />
                    <button type="submit">
                        Pay
                    </button>
                </form>
            </div>
        </>
    );
}