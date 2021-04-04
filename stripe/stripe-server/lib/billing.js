"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.listSubscriptions = exports.cancelSubscription = exports.createSubscription = void 0;
const _1 = require("./");
const firebase_1 = require("./firebase");
const customers_1 = require("./customers");
const firebase_admin_1 = require("firebase-admin");
async function createSubscription(userId, plan, payment_method) {
    const customer = await customers_1.getOrCreateCustomer(userId);
    await _1.stripe.paymentMethods.attach(payment_method, { customer: customer.id });
    await _1.stripe.customers.update(customer.id, {
        invoice_settings: { default_payment_method: payment_method }
    });
    const subscription = await _1.stripe.subscriptions.create({
        customer: customer.id,
        items: [{ 'price': plan }],
        expand: ['latest_invoice.payment_intent']
    });
    const invoice = subscription.latest_invoice;
    const payment_intent = invoice.payment_intent;
    if (payment_intent.status === 'succeeded') {
        await firebase_1.db
            .collection('users')
            .doc(userId)
            .set({
            stripeCustomerId: customer.id,
            activePlans: firebase_admin_1.firestore.FieldValue.arrayUnion(plan)
        }, { merge: true } // do not delete any existing data
        );
    }
    return subscription; // nothing to stop multiple of the same subscription from being bought?
}
exports.createSubscription = createSubscription;
async function cancelSubscription(userId, subscriptionId) {
    const customer = await customers_1.getOrCreateCustomer(userId);
    if (customer.metadata.firebaseUID !== userId) {
        throw Error('Firebase UID does not match Stripe Customer');
    }
    // const subscription = await stripe.subscriptions.update(subscriptionId, { cancel_at_period_end: true });
} // to-do listen for cancel
exports.cancelSubscription = cancelSubscription;
async function listSubscriptions(userId) {
    const customer = await customers_1.getOrCreateCustomer(userId);
    const subscriptions = await _1.stripe.subscriptions.list({
        customer: customer.id,
    });
    return subscriptions;
}
exports.listSubscriptions = listSubscriptions;
//# sourceMappingURL=billing.js.map