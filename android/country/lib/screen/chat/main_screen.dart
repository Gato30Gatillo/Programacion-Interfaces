import 'package:country/domain/entities/country.dart';
import 'package:country/widgets/share/message_field_box.dart';
import 'package:flutter/material.dart';

class MainScreen extends StatelessWidget {
  const MainScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Country"),
        centerTitle: false,
        leading: const Padding(
          padding: EdgeInsets.all(2.0),
            ),
        ),
 body: const _ChatView(),
          );
  }
}

class _ChatView extends StatelessWidget {
  const _ChatView({super.key});

  @override
  Widget build(BuildContext context) {

    return SafeArea(
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Center(
          child: Column(
            children: [  
              Expanded(
              child: ListView.builder(
                itemBuilder: (context, index){
                  //return Container(
                    //Text(Country.name),
                    //child: Image.network(Country.imageUrl),
                    //Text(Country.capital),
                    return const Text("hola");
                    //);
                }
              )
              ),
              const MessagefieldBox()
            ],
          ),
        ),
      ),
    );
  }
} 
