import 'package:flutter/material.dart';
import 'package:widgets_app/config/router/app_router.dart';
import 'package:widgets_app/config/theme/app_theme.dart';

void main() => runApp(const MyApp());

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp.router(
      debugShowCheckedModeBanner: false,
      title: 'Widgets App',
      theme: AppTheme(selectedColor: 0).theme(),
      routerConfig: appRouter,
      //routerConfig: appRouter,{
      //  "/": (context) => const HomeScreen(),
      //  "/Buttons": (context) => const ButtonsScreen(),
      //  "/Cards": (context) => const CardsScreen()
      //}, cuando no habia materialapp.router
    );
  }
}

//añadir todas las pantallas en app_router y menu_items, Ademas estaria bien poner los exports de dichas pantallas en screen