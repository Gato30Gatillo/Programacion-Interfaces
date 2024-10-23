import 'package:ejercicio1/config/menu/menu_items.dart';
import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';

class LoginScreen extends StatelessWidget {
  const LoginScreen({super.key});

  static const name = 'login_screen';
  


  @override
  Widget build(BuildContext context) {
    final item = appMenuItems[0];
    final textControler1= TextEditingController();
    final textControler2= TextEditingController();

    String email = "placeholder";
    String pass = "placeholder";
    return Scaffold(
      appBar: AppBar(
        title: const Text("Material app"),
      ),
      body: Center(
        child: Column(
          children: [
            const Text("user email"),
            TextFormField(onFieldSubmitted: (value) => email=value,controller: textControler1,),
            const Text("Password"),
            TextFormField(onFieldSubmitted: (value) => pass=value,controller: textControler2,),
            IconButton(
              onPressed: () {
                //if(textControler1.text==textControler2.text){
                if(textControler1.text=="a" && textControler2.text=="a"){
                  context.pushNamed(item.name);
                }
                else{
                  return;
                }
            }, 
              icon: const Icon(Icons.arrow_forward_rounded)
            ),
      ],
        ),
      ),
    );
  }
}

