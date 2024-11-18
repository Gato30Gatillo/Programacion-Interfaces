import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';
import 'package:warner/config/menu/menu_items.dart';

class HomeScreen extends StatelessWidget {
  
  static const String name="home_screen";

  const HomeScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        leading: IconButton(onPressed: () {}, 
        icon: const Icon(Icons.arrow_back), color: Colors.white,),
        title: 
        const Center(child: Image(image: AssetImage("assets/images/parque_logo.jpg"),height: 200,)),
      actions: [IconButton(onPressed: (){}, icon: const Icon(Icons.notifications_none),color: Colors.white,)],
      backgroundColor: Colors.blue,
      ),      
      body: const _HomeView(),
    );
  }
}

class _HomeView extends StatelessWidget {
  const _HomeView();

  @override
  Widget build(BuildContext context) {
     return Column(
      children: [
        Padding(
          padding: const EdgeInsets.symmetric(horizontal: 16.0, vertical: 8.0),
          child: Row(
            children: [
              Expanded(
                child: ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    backgroundColor: Colors.yellow,
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(20),
                    ),
                  ),
                  onPressed: () {},
                  icon: const Icon(Icons.search, color: Colors.white),
                  label: const Text("Buscar", style: TextStyle(color: Colors.white)),
                ),
              ),
              const SizedBox(width: 16),
              Expanded(
                child: ElevatedButton.icon(
                  style: ElevatedButton.styleFrom(
                    backgroundColor: Colors.yellow,
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(20),
                    ),
                  ),
                  onPressed: () {},
                  icon: const Icon(Icons.airplane_ticket, color: Colors.white),
                  label: const Text("Mis entradas", style: TextStyle(color: Colors.white)),
                ),
              ),
            ],
          ),
        ),
        Expanded(
          child: PageView(
            scrollDirection: Axis.vertical,
            children: [
              ListView.builder(
                itemCount: appMenuItems.length,
                itemBuilder: (context, index) {
                  final item = appMenuItems[index];
                  return _CustomListTitle(item: item);
                },
              ),
            ],
          ),
        ),
      ],
    );
  }
}

class _CustomListTitle extends StatelessWidget {
  const _CustomListTitle({
    required this.item,
  });

  final MenuItems item;

  @override
  Widget build(BuildContext context) {
    final color = Theme.of(context).colorScheme;

    return ListTile(
      title: Text(item.title),
      leading: Icon(
        item.icon,
        color: color.primary,
      ),
      trailing: Icon(Icons.chevron_right, color: color.primary),
      onTap: () {
        context.pushNamed(item.name);
      },
    );
  }
}
