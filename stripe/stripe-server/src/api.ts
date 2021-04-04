import express, { Request, Response, NextFunction } from 'express';
export const app = express();
import { createSetupIntent, listPaymentMethods } from './customers';
import { auth } from './firebase';

// auto parse from plain text to json
app.use( express.json() )

import cors from 'cors';

// any url can access this api
app.use( cors({origin: true}) )

// set rawBody for webhook handling
app.use(
  express.json({
    verify: (req, res, buffer) => (req['rawBody'] = buffer),
  })
)

// Decodes the Firebase JSON Web Token
app.use(decodeJWT);

// Decodes the JSON Web Token sent viea the frontend app
// Makes the currentUser (firebase) data available on the body
async function decodeJWT(req: Request, res: Response, next: NextFunction) {
  if (req.headers?.authorization?.startsWith('Bearer')) {
    const idToken = req.headers.authorization.split('Bearer')[1].trim();

    console.log(idToken);

    try {
      const decodedToken = await auth.verifyIdToken(idToken);
      console.log(decodedToken);
      req['currentUser'] = decodedToken;
    } catch(err) {
      console.log(err);
    }
  }

  next();
}

app.post('/test/', (req: Request, res: Response) => {

  const amount = req.body.amount;

  res.status(200).send({ with_tax: amount * 7 });

})

import { createStripeCheckoutSession } from './checkout';
app.post(
  '/checkouts/', runAsync( async ({ body }: Request, res: Response) => {
    res.send(
      await createStripeCheckoutSession(body.line_items)
    );
  })
)

import { createPaymentIntent } from './payments';
app.post(
  '/payments/',
  runAsync(async ({ body }: Request, res: Response) => {
    res.send(
      await createPaymentIntent(body.amount)
    );
  })
);

// Save a card on the customer record with a SetupIntent
app.post(
  '/wallet/',
  runAsync( async (req: Request, res: Response) => {
    const user = validateUser(req);
    const setupIntent = await createSetupIntent(user.uid);
    res.send(setupIntent);
  })
)

app.get(
  '/wallet/',
  runAsync( async( req: Request, res: Response) => {
    const user = validateUser(req);

    const wallet = await listPaymentMethods(user.uid);
    res.send(wallet.data);
  })
)

import { handleStripeWebhook } from './webhooks';
// import { auth } from 'firebase-admin';
app.post(
  '/hooks/', runAsync(handleStripeWebhook)
);

import { cancelSubscription, createSubscription, listSubscriptions } from './billing';
app.post(
  '/subscriptions/',
  runAsync(async (req: Request, res: Response) => {
    const user = validateUser(req);
    const { plan, payment_method } = req.body;
    const subscription = await createSubscription(user.uid, plan, payment_method);
    res.send(subscription);
  })
)

app.get(
  '/subscriptions/',
  runAsync(async (req: Request, res: Response) => {
    const user = validateUser(req);
    const subscriptions = await listSubscriptions(user.uid);
    res.send(subscriptions.data);
  })
)

app.patch(
  '/subscriptions/:id',
  runAsync(async (req: Request, res: Response) => {
    const user = validateUser(req);
    res.send(await cancelSubscription(user.uid, req.params.id));
  })
)

// Catch async errors when awaiting promises
function runAsync(callback: Function){
  return (req: Request, res: Response, next: NextFunction) => {
    callback(req, res, next).catch(next);
  }
}

function validateUser(req: Request) {
  const user = req['currentUser'];

  if (!user) {
    throw new Error(
      "You must be logged in to make this request!"
    );
  }

  return user
}