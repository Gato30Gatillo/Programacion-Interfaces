import 'package:ejercicio1/presentation/screens/login_screen.dart';
import 'package:ejercicio1/presentation/screens/main_sceen.dart';
import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';

final appRouter = GoRouter(
  initialLocation: "/",
  routes: <RouteBase>[
    GoRoute(
      path: '/',
      name: LoginScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const LoginScreen();
      },
    ),
    GoRoute(
      path: '/Buttons',
      name: MainSceen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const MainSceen();
      },
    ),
  ],
);