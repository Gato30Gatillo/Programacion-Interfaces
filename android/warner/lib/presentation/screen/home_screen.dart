import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';
import 'package:warner/config/menu/menu_items.dart';

class HomeScreen extends StatefulWidget {
  
  static const String name="home_screen";

  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  @override
  Widget build(BuildContext context) {
    final size = MediaQuery.of(context).size;
    return Scaffold(
      appBar: AppBar(
          toolbarHeight: size.height*0.3,
          leading: IconButton(onPressed: () {}, 
          icon: const Icon(Icons.arrow_back), color: Colors.white,),
          title: 
          Center(child: Image(image: const AssetImage("assets/images/parque_logo_fondo.png"),height: size.height,)),
        actions: [IconButton(onPressed: (){}, icon: const Icon(Icons.notifications_none),color: Colors.white,)],
        backgroundColor: Colors.blue[900],
        ),     
      body: const _HomeView()
    );
  }
}

class _HomeView extends StatefulWidget {
  const _HomeView();

  @override
  State<_HomeView> createState() => _HomeViewState();
}

class _HomeViewState extends State<_HomeView> {
  final ScrollController controler = ScrollController();  
  bool fondo = false;
  @override
  void initState() {
    super.initState();
    controler.addListener(() {
      setState(() {
        fondo = controler.position.pixels+20 >= controler.position.maxScrollExtent;
      });
    });
  }
  @override
  void dispose() {
    controler.dispose();
    super.dispose();
  }


  @override
  Widget build(BuildContext context) {

    final size = MediaQuery.of(context).size;
    

    return Container(
      decoration: BoxDecoration(borderRadius:BorderRadius.circular(20),border: Border.all()),
      child: Column(
        children: [
          Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16.0, vertical: 8.0),
            child: Row(
              children: [
                Expanded(
                  child: ElevatedButton.icon(
                    style: ElevatedButton.styleFrom(
                      backgroundColor: Colors.orange,
                      shape: const RoundedRectangleBorder(
                        borderRadius: BorderRadius.only(bottomLeft: Radius.circular(20),topLeft: Radius.circular(20)),
                      ),
                    ),
                    onPressed: () {},
                    icon: const Icon(Icons.search, color: Colors.white),
                    label: const Text("Buscar", style: TextStyle(color: Colors.white)),
                  ),
                ),
                const SizedBox(width: 2,),
                Expanded(
                  child: ElevatedButton.icon(
                    style: ElevatedButton.styleFrom(
                      backgroundColor: Colors.orange,
                      shape: const RoundedRectangleBorder(
                        borderRadius: BorderRadius.only(topRight: Radius.circular(20),bottomRight: Radius.circular(20)),
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
            child: SingleChildScrollView(
              controller: controler,
              
              child: Column(
                children: [
                  Row(
                    children: [
                      Padding(
                        padding: const EdgeInsets.all(8.0),
                        child: Stack(
                          children: [
                            SizedBox(
                              width: size.width*0.45,
                              child: const ClipRRect(
                                borderRadius: BorderRadius.all(Radius.circular(20)),
                                child: Image(image: AssetImage("assets/images/atracciones.jpg"),fit: BoxFit.fill),
                              ),
                            ),
                            Positioned.fill(
                              child: Container(
                                padding: const EdgeInsets.all(10),
                                decoration: const BoxDecoration(
                                  borderRadius: BorderRadius.all(Radius.circular(20)),
                                  gradient: LinearGradient(
                                    begin: Alignment.topCenter,
                                    end: Alignment.bottomCenter,
                                    colors: [
                                    Colors.black,
                                    Colors.transparent 
                                    ]
                                  )
                                ),
                                width: size.width*0.45,
                                height: size.height*0.25,
                                child: const Text("Atracciones",style:TextStyle(color: Colors.white,fontSize: 20)),
                              ),
                            )
                          ]
                        ),
                      ),
                      Padding(
                        padding: const EdgeInsets.all(8.0),
                        child: Stack(
                          children: [
                            SizedBox(
                              width: size.width*0.45,
                              child: const ClipRRect(
                                borderRadius: BorderRadius.all(Radius.circular(20)),
                                child: Image(image: AssetImage("assets/images/restaurante.jpg"),fit: BoxFit.fill,),
                              )
                            ),
                            Positioned.fill(
                              child: Container(
                                padding: const EdgeInsets.all(10),
                                decoration: const BoxDecoration(
                                  borderRadius: BorderRadius.all(Radius.circular(20)),
                                  gradient: LinearGradient(
                                    begin: Alignment.topCenter,
                                    end: Alignment.bottomCenter,
                                    colors: [
                                    Colors.black,
                                    Colors.transparent 
                                    ]
                                  )
                                ),
                                width: size.width*0.45,
                                height: size.height*0.25,
                                child: const Text("Restaurantes",style:TextStyle(color: Colors.white,fontSize: 20)),
                              ),
                            )
                          ]
                        ),
                      )
                    ],
                  ),
                  Row(
                    children: [
                      Padding(
                        padding: const EdgeInsets.all(8.0),
                        child: Stack(
                          children: [
                            SizedBox(
                              width: size.width*0.95,
                              child: const ClipRRect(
                                borderRadius: BorderRadius.all(Radius.circular(20)),
                                child: Image(image: AssetImage("assets/images/mapa.jpg"),fit: BoxFit.fill)
                              ),
                            ),
                            Positioned.fill(
                              child: Container(
                                padding: const EdgeInsets.all(20),
                                decoration: const BoxDecoration(
                                  borderRadius: BorderRadius.all(Radius.circular(20)),
                                  gradient: LinearGradient(
                                    begin: Alignment.topCenter,
                                    end: Alignment.bottomCenter,
                                    colors: [
                                    Colors.black,
                                    Colors.transparent 
                                    ]
                                  )
                                ),
                                width: size.width*0.95,
                                height: size.height*0.25,
                                child: const Text("Mapa",style:TextStyle(color: Colors.white,fontSize: 30)),
                              ),
                            )
                          ]
                        ),
                      ),
                    ],
                  ),
                  ListView.builder(
                    itemCount: appMenuItems.length,
                    shrinkWrap: true,
                    itemBuilder: (context, index) {
                      final item = appMenuItems[index];
                      return _CustomListTitle(item: item);
                    },
                  ),
                ],
              ),
            ),
          ),
          Visibility(
            visible: !fondo,
            child: const Icon(Icons.arrow_downward_outlined)
          ),
        ],
      ),
    );
    //fondo = controler.position.pixels==controler.position.maxScrollExtent;        
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
