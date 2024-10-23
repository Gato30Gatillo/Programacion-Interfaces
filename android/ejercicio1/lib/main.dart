import 'package:ejercicio1/config/router/app_router.dart';
import 'package:ejercicio1/config/theme/app_theme.dart';
import 'package:flutter/material.dart';

void main() => runApp( const MyApp());


class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp.router(
      title: 'Material App',
      theme: AppTheme(selectedColor: 1).theme(),
      routerConfig: appRouter,
    );
  }
}