import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';
import 'package:warner/presentation/screen/screens.dart';

class LoadingScreen extends StatelessWidget {
  const LoadingScreen({super.key});

  static const String name = "loading_screen";

  @override
  Widget build(BuildContext context) {
    Future.delayed(const Duration(seconds: 3), () {
      context.pushNamed(HomeScreen.name);
    });

    return Scaffold(
      body: Stack(
        children: [
          Positioned.fill(
            child: Image.asset(
              'assets/images/fondo_logo.jpg',
              fit: BoxFit.fill,
            ),
          ),
          const Center(
            child: CircularProgressIndicator(),
          ),
        ],
      ),
    );
  }
}
