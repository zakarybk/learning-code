import React, { useState } from 'react';
import { useStripe } from '@stripe/react-stripe-js';
import { fetchFromAPI } from './helpers';

export function CheckoutFail() {
    return <h3>Checkout failed!</h3>
}

export function CheckoutSuccess() {
    const url = window.location.href;
    const sessionId = new URL(url).searchParams.get('session_id');
    return <h3>Checkout was a success! {sessionId}</h3>
}

export function Checkout(){
    const stripe = useStripe();

    const [product, setProduct] = useState({
        name: 'Hat',
        description: 'Pug',
        images: ['https://images.unsplash.com/photo-1593508512255-86ab42a8e620?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=798&q=80'],
        amount: 799,
        currency: 'gbp',
        quantity: 0
    });

    const changeQuantity = (v) =>
        setProduct({ ...product, quantity: Math.max(0, product.quantity + v)});

    const handleClick = async (event) => {
        const body = { line_items: [product] }
        const { id: sessionId } = await fetchFromAPI('checkouts', {
            body
        });

        const { error } = await stripe.redirectToCheckout({
            sessionId,
        })

        if (error) {
            console.log(error);
        }
    };

    return (
        <>
        <div>
            <h3>{product.name}</h3>

            <h4>Stripe Amount: {product.amount}</h4>

            <img src={product.images[0]} width="250px" alt="product" />

            <span>
                {product.quantity}
            </span>

            <button
                onClick={() => changeQuantity(-1)}>
                -
            </button>
            <span>
                {product.quantity}
            </span>
            <button
                onClick={() => changeQuantity(1)}>
                +
            </button>

            <hr />

            <button
                onClick={handleClick}
                disabled={product.quantity < 1}>
                Start Checkout
            </button>

        </div>
        </>
    );
}