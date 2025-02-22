import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';
import 'package:widgets_app/presentation/screen/screen.dart';


final appRouter = GoRouter(
  initialLocation: "/",
  routes: <RouteBase>[
    GoRoute(
      path: '/',
      name: HomeScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const HomeScreen();
      },
    ),
    GoRoute(
      path: '/Buttons',
      name: ButtonsScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const ButtonsScreen();
      },
    ),
    GoRoute(
      path: '/Cards',
      name: CardsScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const CardsScreen();
      },
    ),
    GoRoute(
      path: '/Progress',
      name: ProgressScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const ProgressScreen();
      },
    ),
    GoRoute(
      path: '/snackbars',
      name: SnackbarScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const SnackbarScreen();
      },
    ),

    GoRoute(
      path: '/animated',
      name: AnimatedScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const AnimatedScreen();
      },
    ),

    GoRoute(
      path: '/ui-controls',
      name: UiControlsScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const UiControlsScreen();
      },    ),

    GoRoute(
      path: '/tutorial',
      name: AppTutorialScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const AppTutorialScreen();
      },    ),

    GoRoute(
      path: '/infinite',
      name: InfiniteScrollScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const InfiniteScrollScreen();
      },    ),

    GoRoute(
      path: '/counter-river',
      name: CounterScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const CounterScreen();
      },
    ),

    GoRoute(
      path: '/theme-changer',
      name: ThemeChangerScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const ThemeChangerScreen();
      },
    ),
  ],
);