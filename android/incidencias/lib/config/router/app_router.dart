import 'package:ejercicio1/presentation/screens/auth_gate.dart';
import 'package:ejercicio1/presentation/screens/main_sceen.dart';
import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';

final appRouter = GoRouter(
  initialLocation: "/",
  routes: <RouteBase>[
    GoRoute(
      path: '/',
      name: const AuthGate().name,
      builder: (BuildContext context, GoRouterState state) {
        return const AuthGate();
      },
    ),
    GoRoute(
      path: '/main_screen/:email',
      name: MainSceen.name,
      builder: (BuildContext context, GoRouterState state) {
        return MainSceen(email: state.pathParameters["email"]);
      },
    ),
  ],
);