import 'package:ejercicio1/presentation/screens/main_sceen.dart';
import 'package:firebase_auth/firebase_auth.dart' hide EmailAuthProvider;
import 'package:firebase_ui_auth/firebase_ui_auth.dart';
import 'package:firebase_ui_oauth_google/firebase_ui_oauth_google.dart';
import 'package:flutter/material.dart';

class AuthGate extends StatelessWidget {
 const AuthGate({super.key});

  final name = 'auth_gate';


 @override
 Widget build(BuildContext context) {

   return StreamBuilder<User?>(
     stream: FirebaseAuth.instance.authStateChanges(),
     builder: (context, snapshot) {
       if (!snapshot.hasData) {
         return SignInScreen(
           providers: [
             //EmailAuthProvider(),
             GoogleProvider(clientId: "963684907742-s21f6jjqud23atkog6l14ebmug3mtnam.apps.googleusercontent.com"),
           ],
           /*headerBuilder: (context, constraints, shrinkOffset) {
             return Padding(
               padding: const EdgeInsets.all(20),
               child: AspectRatio(
                 aspectRatio: 1,
                 child: Image.asset('flutterfire_300x.png'),
               ),
             );
           },*/
           /*subtitleBuilder: (context, action) {
             return Padding(
               padding: const EdgeInsets.symmetric(vertical: 8.0),
               child: action == AuthAction.signIn
                   ? const Text('Welcome to FlutterFire, please sign in!')
                   : const Text('Welcome to Flutterfire, please sign up!'),
             );
           },*/
           footerBuilder: (context, action) {
             return const Padding(
               padding: EdgeInsets.only(top: 16),
               child: Text(
                 'By signing in, you agree to our terms and conditions.',
                 style: TextStyle(color: Colors.grey),
               ),
             );
           },
           /*sideBuilder: (context, shrinkOffset) {
             return Padding(
               padding: const EdgeInsets.all(20),
               child: AspectRatio(
                 aspectRatio: 1,
                 child: Image.asset('flutterfire_300x.png'),
               ),
             );
           },*/
         );
       }

        return MainScreen(email: FirebaseAuth.instance.currentUser?.email);
     },
   );
 }
}
