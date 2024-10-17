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
    )
  ];