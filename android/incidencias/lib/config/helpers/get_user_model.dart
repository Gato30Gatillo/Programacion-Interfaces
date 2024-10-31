import 'package:dio/dio.dart';

class GetUserModel {
  final _dio=Dio();

  Future getAnswer()async{
    final response = await _dio.get("https://script.google.com/macros/s/AKfycbwtqeCI3105QvnYeq00g7WDel1bDYhEi3Ch8bjpMnxajIyAhhEAXexCJamMxburwy00UA/exec?spreadsheetId=1WR0MpsMVbCChMw4kg26OxzkMbiAaEj5UNOQBYnhIGvM&sheet=usuarios-email"); 

    if(response.statusCode==200){
        return response.data;
    }

    throw UnimplementedError();
  }
}