// import 'package:flutter/material.dart';
// import 'package:widgets_app/config/router/app_router.dart';
// import 'package:widgets_app/config/theme/app_theme.dart';

// void main() => runApp(const MyApp());

// class MyApp extends StatelessWidget {
//   const MyApp({super.key});

//   @override
//   Widget build(BuildContext context) {
//     return MaterialApp.router(
//       debugShowCheckedModeBanner: false,
//       title: 'Widgets App',
//       theme: AppTheme(selectedColor: 0).theme(),
//       routerConfig: appRouter,
//       //routerConfig: appRouter,{
//       //  "/": (context) => const HomeScreen(),
//       //  "/Buttons": (context) => const ButtonsScreen(),
//       //  "/Cards": (context) => const CardsScreen()
//       //}, cuando no habia materialapp.router
//     );
//   }
// }
//Antes de la version 11 no le funcionan el counter y el theme changer

//añadir todas las pantallas en app_router y menu_items, Ademas estaria bien poner los exports de dichas pantallas en screen

import 'package:flutter/material.dart';
import 'package:flutter_riverpod/flutter_riverpod.dart';
import 'package:widgets_app/config/router/app_router.dart';
import 'package:widgets_app/config/theme/app_theme.dart';
import 'package:widgets_app/presentation/providers/theme_provider.dart';

void main() {
  runApp(
    const ProviderScope(
      child: MainApp()
    )
  );
}

class MainApp extends ConsumerWidget {
  const MainApp({super.key});

  @override
  Widget build(BuildContext context, WidgetRef ref ) {

    // final isDarkmode = ref.watch(isDarkmodeProvider);
    // final selectedColor = ref.watch(selectedColorProvider);
    final AppTheme appTheme = ref.watch( themeNotifierProvider );

    return MaterialApp.router(
      title: 'Flutter Widgets',
      routerConfig: appRouter,
      debugShowCheckedModeBanner: false,
      theme: appTheme.theme(),
    );
  }
}