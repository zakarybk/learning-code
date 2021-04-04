import firebase from 'firebase/app';
import 'firebase/auth';
import 'firebase/firestore';

export const firebaseConfig = {
    apiKey: "AIzaSyAdeCakLlAlmLVG7Grf9hcoJjXCXgaL-Q8",
    authDomain: "stripe-82069.firebaseapp.com",
    projectId: "stripe-82069",
    storageBucket: "stripe-82069.appspot.com",
    messagingSenderId: "913854342461",
    appId: "1:913854342461:web:74d455e90dd3ab71dd9154"
};

firebase.initializeApp(firebaseConfig);

export const db = firebase.firestore();
export const auth = firebase.auth();