import 'package:ejercicio1/presentation/providers/login_provider.dart';
import 'package:ejercicio1/presentation/screens/main_sceen.dart';
import 'package:firebase_auth/firebase_auth.dart' hide EmailAuthProvider;
import 'package:firebase_ui_auth/firebase_ui_auth.dart';
import 'package:firebase_ui_oauth_google/firebase_ui_oauth_google.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class AuthGate extends StatelessWidget {
 const AuthGate({super.key});

  final name = 'auth_gate';


 @override
 Widget build(BuildContext context) {
    final provider = context.watch<LoginProvider>();

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

        bool isAuthorized = false;
        int longitud = provider.usuarios.length;

        for (int i = 0; i < longitud && !isAuthorized; i++) {
          if (FirebaseAuth.instance.currentUser?.email == provider.usuarios[i].email) {
            isAuthorized = true;
          }
        }

        return isAuthorized 
          ? MainSceen(email: FirebaseAuth.instance.currentUser?.email,)
          : const Scaffold(
              body: Center(
                child: Text('You are not authorized to view this page.'),
              ),
            );
     },
   );
 }
}
