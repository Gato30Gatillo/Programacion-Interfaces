import 'package:flutter/material.dart';

class CounterScreen extends StatelessWidget {
  const CounterScreen({super.key});

  @override
  Widget build(BuildContext context) {
    
    var widthBox=MediaQuery.of(context).size.width;
    var heightBox=MediaQuery.of(context).size.height*0.2;


    return Scaffold(
      
        appBar: AppBar(
          title: const Text('Colores'),
        ),
        body:  Center(
          child: Column(
          children: [ 
          Row(
            children: [
             Container(
              color: Colors.red,
              width: widthBox*0.33,
              height: heightBox,
            ),
            Container(
              color: Colors.green,
              width: widthBox*0.33,
              height: heightBox,
            ),
            Container(
              color: Colors.blue,
              width: widthBox*0.34,
              height: heightBox,
            ),
            ]
          ),
            Row(
            children: [
            Container(
              color: Colors.red,
              width: widthBox*0.5,
              height: heightBox,
            ),
            Container(
              color: Colors.blue,
              width: widthBox*0.5,
              height: heightBox,
            ),
            ]
            ),
            Row(
            children: [
            Container(
              color: Colors.red,
              width: widthBox*0.25,
              height: heightBox,
            ),
            Container(
              color: Colors.green,
              width: widthBox*0.5,
              height: heightBox,
            ),
            Container(
              color: Colors.blue,
              width: widthBox*0.25,
              height: heightBox,
            ),
            ]
            ),
          ]
          )
          ),
        );
  }
}