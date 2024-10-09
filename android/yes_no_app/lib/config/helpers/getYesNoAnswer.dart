import 'package:dio/dio.dart';
import 'package:yes_no_app/domain/entities/message.dart';
import 'package:yes_no_app/infraestructura/models/yes_no_models.dart';

class Getyesnoanswer {
  final dio=Dio();

  Future<Message> getAnswer()async{
    final response = await dio.get("https://yesno.wtf/api"); 

    if(response.statusCode==200){
        final yesnomodel= YesNoModel.fromJsonMap(response.data);
        return yesnomodel.toMessageEntity();
    }

    throw UnimplementedError();
  }
}