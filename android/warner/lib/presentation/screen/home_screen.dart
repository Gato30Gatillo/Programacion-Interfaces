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
        const Center(child: Image(image: AssetImage("assets/images/parque_logo.jpg"))),
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
    return Container(
      color: Colors.white,
      child: Column(
        children: [
          Row(
            children: [
              IconButton(onPressed: (){}, icon: const Icon(Icons.search),),
              IconButton(onPressed: (){}, icon: const Icon(Icons.token),),
            ],
          ),
          PageView(
            
            children: [ 
              const Row(
                children: [
                  Image(image: AssetImage("assets/images/parque_logo.jpg")),
                  Image(image: AssetImage("assets/images/parque_logo.jpg"))
                ],
              ),
              const Row(
                children: [
                  Image(image: AssetImage("assets/images/parque_logo.jpg"))
                ],
              ),
              ListView.builder(
              itemCount: appMenuItems.length,
              itemBuilder: (context, index) {
                final item = appMenuItems[index];
                return _CustomListTitle(item: item);
              },
            ),
            ]
          ),
        ],
      ),
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
      leading: Icon(item.icon, color: color.primary,),
      trailing: Icon(Icons.chevron_right, color: color.primary),
      onTap: (){
        context.pushNamed(item.name);
      }
      );
  }
}