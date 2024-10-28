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
      path: '/main_screen/:email:pass',
      name: MainSceen.name,
      builder: (BuildContext context, GoRouterState state) {
        return MainSceen(email: state.pathParameters["email"], pass: state.pathParameters["pass"],);
      },
    ),
  ],
);