import 'package:flutter/material.dart';

class MainSceen extends StatelessWidget {
  const MainSceen({super.key,this.email,this.pass});

  static const name = 'main_screen';
  final String? email;
  final String? pass;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(email!),
      ),
      body: const Column(
        children: [
          Text("Bienvenido")
        ],
      ),
    );
  }
}