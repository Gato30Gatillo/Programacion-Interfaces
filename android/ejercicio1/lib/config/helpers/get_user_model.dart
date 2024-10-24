import 'package:dio/dio.dart';
import 'package:ejercicio1/domain/entities/user.dart';
import 'package:ejercicio1/infraestructure/models/user_model.dart';

class GetUserModel {
  final dio=Dio();

  Future<UserModel> getAnswer()async{
    final response = await dio.get("https://script.google.com/macros/s/AKfycbwDv0d_GQWzGZrXD2V7b_ycX7DGSNk9i3Sw9g7wfxoHq8m-fhczTZTsr8k15CQcYlrU/exec?spreadsheetId=1p5gLnar8Un2DHa1QtP0Nvod6jyExvdJ3bZnfwUePsa4&sheet=usuarios"); 

    if(response.statusCode==200){
        final usermodel= UserModel.fromJsonMap(response.data);
        return usermodel;
    }

    throw UnimplementedError();
  }
}