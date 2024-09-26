import 'package:flutter/material.dart';

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    
    var height_box=MediaQuery.of(context).size.width;
    var width_box=MediaQuery.of(context).size.width*0.2;


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
              width: width_box*0.33,
              height: height_box,
            ),
            Container(
              color: Colors.green,
              width: width_box*0.33,
              height: height_box,
            ),
            Container(
              color: Colors.blue,
              width: width_box*0.34,
              height: height_box,
            ),
            ]
          ),
            Row(
            children: [
            Container(
              color: Colors.red,
              width: width_box*0.5,
              height: height_box,
            ),
            Container(
              color: Colors.blue,
              width: width_box*0.5,
              height: height_box,
            ),
            ]
            ),
            Row(
            children: [
            Container(
              color: Colors.red,
              width: width_box*0.25,
              height: height_box,
            ),
            Container(
              color: Colors.green,
              width: width_box*0.5,
              height: height_box,
            ),
            Container(
              color: Colors.blue,
              width: width_box*0.25,
              height: height_box,
            ),
            ]
            ),
          ]
          )
          ),
        );
  }
}