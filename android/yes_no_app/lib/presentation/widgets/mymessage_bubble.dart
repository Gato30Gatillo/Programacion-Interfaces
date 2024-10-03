import 'package:flutter/material.dart';

class MymessageBubble extends StatelessWidget {
  const MymessageBubble({super.key});

  @override
  Widget build(BuildContext context) {
    
    final colors= Theme.of(context).colorScheme;

    return Column(
      crossAxisAlignment: CrossAxisAlignment.end,
      children: [
        Container(
          decoration: BoxDecoration(
            color: colors.primary,
            borderRadius: BorderRadius.circular(20)
          ),
          child: const Padding(
            padding: EdgeInsets.symmetric(horizontal: 20, vertical: 10),
            child: Text("texto de prueba para ver como se ve", style: TextStyle(color: Colors.white),),
          ),
        ),
        const SizedBox(height: 10,)
      ],
    );
  }
}