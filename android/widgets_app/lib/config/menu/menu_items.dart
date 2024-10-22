import 'package:flutter/material.dart';
import '../../presentation/screen/screen.dart';

class MenuItems {
  final String title;
  final String subtitle;
  final String link;
  final IconData icon;
  final String name;

  const MenuItems({
    required this.title, 
    required this.subtitle, 
    required this.link, 
    required this.icon,
    required this.name});
}

  const appMenuItems = <MenuItems>[
    MenuItems(
      icon: Icons.smart_button_outlined,
      link: "/Buttons",
      subtitle: "varios botones en flutter",
      title: "Botones",
      name: ButtonsScreen.name  
    ),
    MenuItems(
      icon: Icons.credit_card,
      link: "/Cards",
      subtitle: "un contenedor estilizado",
      title: "Cards",
      name: CardsScreen.name  
    ),
    MenuItems(
      icon: Icons.refresh_rounded,
      link: "/Progress",
      subtitle: "generales y contolados",
      title: "Progess indicator",
      name: ProgressScreen.name  
    ),
    MenuItems(
    title: 'Riverpod Counter', 
    subtitle: 'Introducción a riverpod', 
    link: '/counter-river', 
    icon: Icons.add,
    name: CounterScreen.name
    ),
    MenuItems(
    title: 'Snackbars y diálogos', 
    subtitle: 'Indicadores en pantalla', 
    link: '/snackbars', 
    icon: Icons.info_outline,
    name: SnackbarScreen.name
  ),

  MenuItems(
    title: 'Animated container', 
    subtitle: 'Stateful widget animado', 
    link: '/animated', 
    icon: Icons.check_box_outline_blank_rounded,
    name: AnimatedScreen.name
  ),

  MenuItems(
    title: 'UI Controls + Tiles', 
    subtitle: 'Una serie de controles de Flutter', 
    link: '/ui-controls', 
    icon: Icons.car_rental_outlined,
    name: UiControlsScreen.name
  ),

  MenuItems(
    title: 'Introducción a la aplicación', 
    subtitle: 'Pequeño tutorial introductorio', 
    link: '/tutorial', 
    icon: Icons.accessible_rounded,
    name: AppTutorialScreen.name
  ),

  MenuItems(
    title: 'InfiniteScroll y Pull', 
    subtitle: 'Listas infinitas y pull to refresh', 
    link: '/infinite', 
    icon: Icons.list_alt_rounded,
    name: InfiniteScrollScreen.name
  ),

  MenuItems(
    title: 'Cambiar tema', 
    subtitle: 'Cambiar tema de la aplicación', 
    link: '/theme-changer', 
    icon: Icons.color_lens_outlined,
    name: ThemeChangerScreen.name
  ),
  ];