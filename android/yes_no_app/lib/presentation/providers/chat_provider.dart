import 'package:flutter/material.dart';
import 'package:yes_no_app/domain/entities/message.dart';

class ChatProvider extends ChangeNotifier {

  List<Message> message=[
    Message(
      text: "ella", 
      fromWho: FromWho.hers
      ),
    Message(
      text: "el", 
      fromWho: FromWho.my)
  ];

  Future<void> sendMessage(String text) async{
    message.add(Message(text: text, fromWho: FromWho.my));
    notifyListeners();
  }
}