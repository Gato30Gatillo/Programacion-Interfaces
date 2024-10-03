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
        leading: IconButton(
          onPressed: (){}, 
          icon: const Icon(Icons.refresh_rounded),
      ),
      actions: [IconButton(
          onPressed: (){
            counter=0;
            setState((){});
          }, 
          icon: const Icon(Icons.refresh_rounded),
      )],
      ),
      body: Center(
        child: Column( 
          mainAxisAlignment: MainAxisAlignment.center,
          //crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text("$counter",style: const TextStyle(fontSize: 160,fontWeight: FontWeight.w100),),
            Text (click, style: const TextStyle(fontSize: 25),)
            

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
      floatingActionButton: Row(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          
      // FloatingActionButton(
        
      //   onPressed: (){
      //     counter++;
      //     if (counter==1){
      //       click="click";
      //     }
      //     else{
      //       click="clicks";
      //     }
      //     setState((){});
      //   },
      //   child: const Icon(Icons.plus_one),
      //   ),
      //   FloatingActionButton(
      //   onPressed: (){
      //     if(counter!=0){
      //     counter--;
      //     }
      //     if (counter==1){
      //       click="click";
      //     }
      //     else{
      //       click="clicks";
      //     }
      //     setState((){});
      //   },
      //   child: const Text("-1"),
      //   ),
        CustomButton(
          icon: Icons.plus_one,
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
          ),
          const SizedBox(height: 10,width: 10,),
          CustomButton(
          icon: Icons.exposure_minus_1,
          onPressed: (){
            if(counter!=0){
            counter--;
            }
            if (counter==1){
            click="click";
          }
          else{
            click="clicks";
          }
            setState((){});
          },
          ),
          const SizedBox(height: 10,width: 10,),
          CustomButton(
          icon: Icons.refresh_outlined,
          onPressed: (){
            counter=0;
            if (counter==1){
            click="click";
          }
          else{
            click="clicks";
          }
            setState((){});
          },
          ),
          const SizedBox(height: 10,width: 10,),
        ]
        ),
    );
  }
}

class CustomButton extends StatelessWidget {
  final IconData icon;
  final VoidCallback? onPressed;
  const CustomButton({
    super.key,
    required this.icon,
    this.onPressed
  });

  @override
  Widget build(BuildContext context) {
    return FloatingActionButton(
    backgroundColor: Colors.blue,
    shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(20)),
    onPressed: onPressed,
    child: Icon(icon),
    );
  }
}