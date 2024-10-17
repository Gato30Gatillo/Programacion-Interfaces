import 'package:flutter/material.dart';

class ButtonsScreen extends StatelessWidget {
  const ButtonsScreen({super.key});
  static const String name="buttons_screen";

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Buttons screen"),
      ),
      body: Wrap(
      spacing: 10,
      children: [
        IconButton(
          onPressed: () {},
          icon: const Icon(Icons.table_chart_outlined),
          style: ButtonStyle(
            backgroundColor: WidgetStateProperty.resolveWith<Color?>(
              (set<WidgetState> states) (
                if(status.contains(WidgetState.pressed)){
                  return Colors.red
                }
                else if(status.contains(WidgetState.hovered)){
                  return Colors.blue
                }
                else if(status.contains(WidgetState.dragged)){
                  return Colors.green
                }
              ),
          ),
        )
        )
      ]
      )
    );
  }
}