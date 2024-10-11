import 'package:country/presentation/providers/country_provider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class MessagefieldBox extends StatelessWidget {
  const MessagefieldBox({super.key});

  @override
  Widget build(BuildContext context) {

    final countryprovider = context.watch<CountryProvider>();
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
            final textValue=textControler.value.text;
            countryprovider.reply(textValue);
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
        countryprovider.reply(value);
        textControler.clear();
        focusNode.requestFocus();
      },
    );
  }
}
