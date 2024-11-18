import 'package:flutter/material.dart';
import 'package:warner/presentation/screen/screens.dart';

class MenuItems {
  final String title;
  final String link;
  final IconData icon;
  final String name;

  const MenuItems({
    required this.title,  
    required this.link, 
    required this.icon,
    required this.name});
}

  const appMenuItems = <MenuItems>[
    MenuItems(
      icon: Icons.shop,
      link: "/Tienda",
      title: "Tienda",
      name: TiendaScreen.name  
    ),
    MenuItems(
      icon: Icons.map,
      link: "/ComoLlegar",
      title: "Como llegar",
      name: ComoLlegarScreen.name  
    ),
    MenuItems(
      icon: Icons.calendar_month_outlined,
      link: "/HorarioApertura",
      title: "Horario apertura",
      name: HorarioAperturaScreen.name  
    ),
    MenuItems(
    title: 'Otros servicios', 
    link: '/OtrosServicios', 
    icon: Icons.print_outlined,
    name: OtrosServiciosScreen.name
    ),
    MenuItems(
    title: 'Normas de funcionamiento', 
    link: '/NormasFuncionamiento', 
    icon: Icons.edit_document,
    name: NormasFuncionamientoScreen.name
  ),
  ];
  