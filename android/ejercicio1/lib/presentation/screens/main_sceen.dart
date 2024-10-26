import 'package:ejercicio1/presentation/screens/login_screen.dart';
import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';

class MainSceen extends StatelessWidget {
  const MainSceen({super.key,this.email,});

  static const name = 'main_screen';
  final String? email;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        centerTitle: true ,
        title: const Text("Aplication"),
      ), 
      body: Center(
        child: Column(
          children: [
            Text("Bienvenido $email" ),
            IconButton( 
            icon: const Icon(Icons.arrow_back), 
            onPressed: () => context.goNamed(LoginScreen.name),
            ),
          ],
        ),
      ),
    );
  }
}