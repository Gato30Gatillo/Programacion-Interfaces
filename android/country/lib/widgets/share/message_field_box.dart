import 'package:flutter/material.dart';

class MessagefieldBox extends StatelessWidget {
  const MessagefieldBox({super.key});

  @override
  Widget build(BuildContext context) {

    final textControler= TextEditingController();
    final focusNode=FocusNode();

    final underlineInputBorder = UnderlineInputBorder(
      borderSide: const BorderSide(color: Colors.transparent),
      borderRadius: BorderRadius.circular(20),
    );

    final inputDecoration = InputDecoration(
        enabledBorder: underlineInputBorder,
        focusedBorder: underlineInputBorder,
        filled: true,
        hintText: "escribe el pais",
        suffixIcon: IconButton(
          icon: const Icon(Icons.send),
          onPressed: () {
            textControler.clear();
          },
        ));

    return TextFormField(
      onTapOutside: (event){
        focusNode.unfocus();
      },
      focusNode: focusNode,
      controller: textControler,
      decoration: inputDecoration,
      onFieldSubmitted: (value) {
        //print("$value");
        textControler.clear();
        focusNode.requestFocus();
      },
    );
  }
}
