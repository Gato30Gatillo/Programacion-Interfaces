import 'package:country/domain/entities/country.dart';
import 'package:country/presentation/providers/country_provider.dart';
import 'package:country/widgets/share/country_bubble.dart';
import 'package:country/widgets/share/message_field_box.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

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
  const _ChatView();


  @override
  Widget build(BuildContext context) {

    final provider = context.watch<CountryProvider>();

    return SafeArea(
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Center(
          child: Column(
            children: [  
              Expanded(
              child: ListView.builder(
                itemCount: provider.countryList.length,
                itemBuilder: (context, index){
                  Country pais = provider.countryList[0];
                  return CountryBubble(country: pais);
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