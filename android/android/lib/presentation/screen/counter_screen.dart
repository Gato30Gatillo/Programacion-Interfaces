import 'package:flutter/material.dart';
class CounterScreen extends StatefulWidget {
  const CounterScreen({super.key});

  @override
  State<CounterScreen> createState() => _CounterScreenState();
}

class _CounterScreenState extends State<CounterScreen> {
    int counter=0;
    String click="click";
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Center(child: Text("Counter Screen",style: TextStyle(fontSize: 55),)),
      ),
      body: Center(
        child: Column( 
          mainAxisAlignment: MainAxisAlignment.center,
          //crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text("$counter",style: const TextStyle(fontSize: 160,fontWeight: FontWeight.w100),),
            Text (click, style: TextStyle(fontSize: 25),)
            

          ],
          /* children: [
             Text("Counter",style: TextStyle(fontSize: 24),),
             SizedBox(
               height: 300,
               width: 300,
             ),
             Expanded(child: Text('0',style: TextStyle(fontSize: 40),)),
             ElevatedButton(onPressed: null, child: Text("Incrementar"))] */
          ),
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: (){
          counter++;
          if (counter==1){
            click="click";
          }
          else{
            click="clicks";
          }
          setState((){});
        },
        child: const Icon(Icons.plus_one),
        ),
    );
  }
}