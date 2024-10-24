import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:yes_no_app/presentation/providers/chat_provider.dart';

class MessagefieldBox extends StatelessWidget {
  const MessagefieldBox({super.key});

  @override
  Widget build(BuildContext context) {
    //final colors= Theme.of(context).colorScheme;

    final chatprovider = context.watch<ChatProvider>();
    final textControler= TextEditingController();
    final focusNode=FocusNode();

    final underlineInputBorder = UnderlineInputBorder(
      borderSide: const BorderSide(color: Colors.transparent),
      borderRadius: BorderRadius.circular(20),
    );

    final inputDecoration = InputDecoration(
        enabledBorder: underlineInputBorder,
        /*borderSide: BorderSide(
            color: colors.primary,
            ),
            borderRadius: BorderRadius.circular(20),*/
        focusedBorder: underlineInputBorder,
        filled: true,
        hintText: "end your message with a ??",
        suffixIcon: IconButton(
          icon: const Icon(Icons.send),
          onPressed: () {
            final textValue=textControler.value.text;
            //print("send mesagge $textValue");
            chatprovider.sendMessage(textValue);
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
        chatprovider.sendMessage(value);
        textControler.clear();
        focusNode.requestFocus();
      },
      onChanged: (value) {
        print("changed: $value");
      },
    );
  }
}
