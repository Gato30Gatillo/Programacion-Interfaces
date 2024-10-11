import 'package:country/presentation/providers/country_provider.dart';
import 'package:country/screen/chat/main_screen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

void main() => runApp(const MyApp());

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [ChangeNotifierProvider(create:(_)=> CountryProvider())],
      child: const MaterialApp(
      title: 'Country',
      home: MainScreen()
    )
    );
  }
}