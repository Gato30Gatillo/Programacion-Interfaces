import 'package:flutter/material.dart';
import 'package:widgets_app/config/theme/app_theme.dart';

void main() => runApp(const MyApp());

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Widgets App',
      theme: AppTheme(selectedColor: 0).theme(),
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Widgets App Bar'),
        ),
        body: Center(
          child: FilledButton(onPressed: (){}, child: const Text("filled button")),
        ),
      ),
    );
  }
}