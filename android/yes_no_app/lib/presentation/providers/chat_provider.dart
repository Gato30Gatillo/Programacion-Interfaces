import 'package:flutter/material.dart';
import 'package:yes_no_app/domain/entities/message.dart';

class ChatProvider extends ChangeNotifier {

  List<Message> messageList=[
    Message(
      text: "hola", 
      fromWho: FromWho.my
      ),
    Message(
      text: "que tal", 
      fromWho: FromWho.my)
  ];

  final ScrollController scrollcontroler= ScrollController(); 

  Future<void> sendMessage(String text) async{
    if (text.isEmpty){
    }
    else{
      messageList.add(Message(text: text, fromWho: FromWho.my));
      notifyListeners();
      moveScrollToBotton();
    }
  }

  Future<void> moveScrollToBotton() async {
    await Future.delayed((const Duration(milliseconds: 100)));
    scrollcontroler.animateTo(
      scrollcontroler.position.maxScrollExtent,
      duration: const Duration(seconds: 1),
      curve: Curves.easeOut
    );
  }

}