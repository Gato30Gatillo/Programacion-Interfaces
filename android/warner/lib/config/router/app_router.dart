import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';
import 'package:warner/presentation/screen/screens.dart';


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
      path: '/tienda',
      name: TiendaScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const TiendaScreen();
      },
    ),
    GoRoute(
      path: '/como_llegar',
      name: ComoLlegarScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const ComoLlegarScreen();
      },
    ),
    GoRoute(
      path: '/horario_apertura',
      name: HorarioAperturaScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const HorarioAperturaScreen();
      },
    ),
    GoRoute(
      path: '/otros_servicios',
      name: OtrosServiciosScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const OtrosServiciosScreen();
      },
    ),
    GoRoute(
      path: '/normas_funcionamiento',
      name: NormasFuncionamientoScreen.name,
      builder: (BuildContext context, GoRouterState state) {
        return const NormasFuncionamientoScreen();
      },
    ),
  ],
);