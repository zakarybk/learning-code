"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.createStripeCheckoutSession = void 0;
const _1 = require("./");
async function createStripeCheckoutSession(line_items) {
    // Example Item
    // name: 
    // description:
    // images: []
    // amount: 
    // currency: 
    // quantity:
    const url = process.env.WEBAPP_URL;
    const session = await _1.stripe.checkout.sessions.create({
        payment_method_types: ['card'],
        line_items,
        success_url: `${url}/success?session_id={CHECKOUT_SESSION_ID}`,
        cancel_url: `${url}/failed`,
    });
    return session;
}
exports.createStripeCheckoutSession = createStripeCheckoutSession;
//# sourceMappingURL=checkout.js.map