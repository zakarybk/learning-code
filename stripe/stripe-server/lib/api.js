"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.app = void 0;
const express_1 = __importDefault(require("express"));
exports.app = express_1.default();
const customers_1 = require("./customers");
const firebase_1 = require("./firebase");
// auto parse from plain text to json
exports.app.use(express_1.default.json());
const cors_1 = __importDefault(require("cors"));
// any url can access this api
exports.app.use(cors_1.default({ origin: true }));
// set rawBody for webhook handling
exports.app.use(express_1.default.json({
    verify: (req, res, buffer) => (req['rawBody'] = buffer),
}));
// Decodes the Firebase JSON Web Token
exports.app.use(decodeJWT);
// Decodes the JSON Web Token sent viea the frontend app
// Makes the currentUser (firebase) data available on the body
async function decodeJWT(req, res, next) {
    var _a, _b;
    if ((_b = (_a = req.headers) === null || _a === void 0 ? void 0 : _a.authorization) === null || _b === void 0 ? void 0 : _b.startsWith('Bearer')) {
        const idToken = req.headers.authorization.split('Bearer')[1].trim();
        console.log(idToken);
        try {
            const decodedToken = await firebase_1.auth.verifyIdToken(idToken);
            console.log(decodedToken);
            req['currentUser'] = decodedToken;
        }
        catch (err) {
            console.log(err);
        }
    }
    next();
}
exports.app.post('/test/', (req, res) => {
    const amount = req.body.amount;
    res.status(200).send({ with_tax: amount * 7 });
});
const checkout_1 = require("./checkout");
exports.app.post('/checkouts/', runAsync(async ({ body }, res) => {
    res.send(await checkout_1.createStripeCheckoutSession(body.line_items));
}));
const payments_1 = require("./payments");
exports.app.post('/payments/', runAsync(async ({ body }, res) => {
    res.send(await payments_1.createPaymentIntent(body.amount));
}));
// Save a card on the customer record with a SetupIntent
exports.app.post('/wallet/', runAsync(async (req, res) => {
    const user = validateUser(req);
    const setupIntent = await customers_1.createSetupIntent(user.uid);
    res.send(setupIntent);
}));
exports.app.get('/wallet/', runAsync(async (req, res) => {
    const user = validateUser(req);
    const wallet = await customers_1.listPaymentMethods(user.uid);
    res.send(wallet.data);
}));
const webhooks_1 = require("./webhooks");
// import { auth } from 'firebase-admin';
exports.app.post('/hooks/', runAsync(webhooks_1.handleStripeWebhook));
const billing_1 = require("./billing");
exports.app.post('/subscriptions/', runAsync(async (req, res) => {
    const user = validateUser(req);
    const { plan, payment_method } = req.body;
    const subscription = await billing_1.createSubscription(user.uid, plan, payment_method);
    res.send(subscription);
}));
exports.app.get('/subscriptions/', runAsync(async (req, res) => {
    const user = validateUser(req);
    const subscriptions = await billing_1.listSubscriptions(user.uid);
    res.send(subscriptions.data);
}));
exports.app.patch('/subscriptions/:id', runAsync(async (req, res) => {
    const user = validateUser(req);
    res.send(await billing_1.cancelSubscription(user.uid, req.params.id));
}));
// Catch async errors when awaiting promises
function runAsync(callback) {
    return (req, res, next) => {
        callback(req, res, next).catch(next);
    };
}
function validateUser(req) {
    const user = req['currentUser'];
    if (!user) {
        throw new Error("You must be logged in to make this request!");
    }
    return user;
}
//# sourceMappingURL=api.js.map