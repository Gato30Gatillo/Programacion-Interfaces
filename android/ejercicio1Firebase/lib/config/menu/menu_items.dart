import 'package:ejercicio1/presentation/screens/main_sceen.dart';

class MenuItems {
  final String title;
  final String link;
  final String name;

  const MenuItems({
    required this.title, 
    required this.link, 
    required this.name});
}

  const appMenuItems = <MenuItems>[
    MenuItems(
      link: "/Main",
      title: "Main",
      name: MainSceen.name  
    ),
  ];