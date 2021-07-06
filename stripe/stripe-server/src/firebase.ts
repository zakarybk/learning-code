import * as firebaseAdmin from 'firebase-admin';
firebaseAdmin.initializeApp(); // looks for env GOOGLE_APPLICATION_CREDENTIALS

export const db = firebaseAdmin.firestore();
export const auth = firebaseAdmin.auth();