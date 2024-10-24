import 'package:ejercicio1/presentation/providers/login_provider.dart';
import 'package:ejercicio1/presentation/screens/main_sceen.dart';
import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';
import 'package:provider/provider.dart';

class LoginScreen extends StatelessWidget {
  const LoginScreen({super.key});

  static const name = 'login_screen';
  


  @override
  Widget build(BuildContext context) {
    final textControler1= TextEditingController();
    final textControler2= TextEditingController();
    final provider = context.watch<LoginProvider>();


    return Scaffold(
      appBar: AppBar(
        title: const Text("Material app"),
      ),
      body: Center(
        child: Column(
          children: [
            const Text("user email"),
            TextFormField(onFieldSubmitted: (value) => MainSceen(email: value,),controller: textControler1,),
            const Text("Password"),
            TextFormField(onFieldSubmitted: (value) => MainSceen(pass: value,),controller: textControler2,),
            IconButton(
              onPressed: () {
                LoginProvider().getUsuarios();
                //if(textControler1.text==textControler2.text){
                for(int i=0 ;i<LoginProvider().usuarios.length ;i++){
                final usuario=LoginProvider().usuarios[i];
                if(textControler1.text==usuario.correo && textControler2.text==usuario.clave){
                  context.pushNamed(MainSceen.name);
                }
                else{
                  return;
                }
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

