import logo from './logo.svg';
import './App.css';

import React from 'react';

import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';

import { Checkout, CheckoutSuccess, CheckoutFail } from './Checkout';
import Payments from './Payments';
import Customers from './Customers';
import Subscriptions from './Subscriptions';

export default function App() {
  return (
    <Router>
      <div>
        <nav>
          <ul className="navbar-nav">
            <li>
              <Link to="/">Home</Link>
            </li>
            <li>
              <Link to="/checkout">
                <span aria-label="emoji" role="img">
                  🛒
                </span>{' '}
                Checkout
              </Link>
            </li>
            <li>
              <Link to="/payments">
                <span aria-label="emoji" role="img">
                  💸
                </span>{' '}
                Payments
              </Link>
            </li>
            <li>
              <Link to="/customers">
                <span aria-label="emoji" role="img">
                  🧑🏿‍🤝‍🧑🏻
                </span>{' '}
                Customers
              </Link>
            </li>
          </ul>
          <li>
              <Link to="/subscriptions">
                <span aria-label="emoji" role="img">
                  🔄
                </span>{' '}
                Subscriptions
              </Link>
            </li>
        </nav>

        <main>
          <Switch>
            <Route path="/checkout">
              <Checkout />
            </Route>
            <Route path="/payments">
              <Payments />
            </Route>
            <Route path="/customers">
              <Customers />
            </Route>
            <Route path="/subscriptions">
              <Subscriptions />
            </Route>
            <Route path="/success">
              <CheckoutSuccess />
            </Route>
            <Route path="/failed">
              <CheckoutFail />
            </Route>
            <Route path="/">
              <Home />
            </Route>
          </Switch>
        </main>
      </div>
    </Router>
  );
}

function Home() {
  return (
    <>
      <h2>Stripe React + Node.js</h2>
    </>
  );
}
