import 'package:ejercicio1/presentation/providers/login_provider.dart';
import 'package:ejercicio1/presentation/screens/login_screen.dart';
import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';
import 'package:provider/provider.dart';

class MainSceen extends StatelessWidget {
  const MainSceen({super.key,this.email, this.pass,});

  static const name = 'main_screen';
  final String? email;
  final String? pass;

  @override
  Widget build(BuildContext context) {
    final provider = context.read<LoginProvider>();
    bool dialogShown = false;
    return Scaffold(
      appBar: AppBar(
        centerTitle: true ,
        title: Text("Bienvenido $email" ),
            leading: IconButton( 
            icon: const Icon(Icons.arrow_back), 
            onPressed: () => context.goNamed(LoginScreen.name),
            )
      ), 
      body: Center(
        child: Center(
        child: FutureBuilder(
          future: provider.getUsuarios(),
          builder: (BuildContext context, AsyncSnapshot snapshot) {
            if (snapshot.connectionState == ConnectionState.waiting) {
              return const CircularProgressIndicator();
            }
            if (snapshot.connectionState == ConnectionState.done) {
              int longitud = provider.usuarios.length;
              bool encontrado = false;

              for (int i = 0; i < longitud && !encontrado; i++) {
                final usuario = provider.usuarios[i];
                if (email == usuario.nombre && pass == usuario.clave) {
                  encontrado = true;
                  return const Text("Bienvenido amigo");
                }
              }

              if (!encontrado && !dialogShown) {
                dialogShown = true;
                Future.delayed(Duration.zero, () {
                  showDialog(
                    context: context,
                    builder: (context) {
                      return const AlertDialog(
                        content: Text("El usuario o la contraseña no existen"),
                      );
                    },
                  ).then((_) => context.goNamed(LoginScreen.name));
                });
                return const SizedBox.shrink();
              }
            }
            return const CircularProgressIndicator();
          },
        ),
      ), 
    )
    );
  }
}
