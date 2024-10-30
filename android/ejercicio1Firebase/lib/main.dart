import 'package:ejercicio1/config/router/app_router.dart';
import 'package:ejercicio1/firebase_options.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:provider/provider.dart';
import 'package:ejercicio1/config/theme/app_theme.dart';
import 'package:ejercicio1/presentation/providers/login_provider.dart';
import 'package:flutter/material.dart';

void main() async {
 WidgetsFlutterBinding.ensureInitialized();
 await Firebase.initializeApp(
   options: DefaultFirebaseOptions.currentPlatform,
 );


 runApp(const MyApp());
}


class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      
      providers: [ChangeNotifierProvider(create:(_)=> LoginProvider(),lazy: false,)],
      child: MaterialApp.router(
        title: 'Material App',
        theme: AppTheme(selectedColor: 1).theme(),
        routerConfig: appRouter,
      ),
    );
    
  }
}