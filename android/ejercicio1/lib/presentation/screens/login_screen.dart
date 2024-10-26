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
        title: const Text("Login"),
      ),
      body: Center(
        child: Column(
          children: [
            const Text("user email"),
            TextFormField(onFieldSubmitted: (value) => MainSceen(email: value,),controller: textControler1,),
            const Text("Password"),
            TextFormField(onFieldSubmitted: (value) => (),controller: textControler2, obscureText: true,),
            IconButton(
              onPressed: () async {
                await provider.getUsuarios();
                int longitud = provider.usuarios.length;
                bool encontrado=false;
                var email=textControler1.text;
                //if(textControler1.text==textControler2.text){
                for(int i=0 ;i<longitud && !encontrado ;i++){
                  final usuario=provider.usuarios[i];
                  if(textControler1.text==usuario.nombre && textControler2.text==usuario.clave){
                    encontrado=true;
                    context.goNamed(MainSceen.name, pathParameters: {"email": email}); 
                  }
                }
                if(!encontrado){
                  showDialog(
                    context: context, 
                    builder: (
                      context){ 
                        return const AlertDialog(
                          content: Text("El usuario o la contraseña no existen"),
                        );
                        }
                    
                    );
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

