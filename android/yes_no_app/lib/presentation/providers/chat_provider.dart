import 'package:flutter/material.dart';
import 'package:yes_no_app/config/helpers/getYesNoAnswer.dart';
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
  final Getyesnoanswer GetYesNoAnswer = Getyesnoanswer();

  Future<void> herReply()async{
    final hermessage = await GetYesNoAnswer.getAnswer();
    if(hermessage.text.isEmpty) return;
    messageList.add(hermessage);
    notifyListeners();
    moveScrollToBotton();
  }

  Future<void> sendMessage(String text) async{
    if (text.isEmpty){
    }
    else{
      messageList.add(Message(text: text, fromWho: FromWho.my));
      if (text.endsWith("?")){
        await herReply();
      }
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