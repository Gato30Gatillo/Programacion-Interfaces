import 'package:ejercicio1/config/helpers/get_user_model.dart';
import 'package:ejercicio1/infraestructure/models/user_model.dart';
import 'package:flutter/material.dart';

class LoginProvider extends ChangeNotifier {

  List<UserModel> usuarios=[];
  bool initialLoading=true;

  Future<void> getUsuarios()async{
    //print("ANTES DEL RESPONSE");
    await Future.delayed(const Duration(seconds: 2));
    final response = await GetUserModel().getAnswer();
    //print("DESPUES DEL RESPONSE");
    usuarios.clear();
    
    //print("DESPUES DEL clear");
    //List <UserModel> lista = userModelFromJson(response);
    //print(usuarios.length);
    usuarios.addAll(userModelFromJson(response));
    //print(usuarios);
    //print(usuarios.length);
    initialLoading=false;
    notifyListeners();
  }

}
//enlace al exel
//https://docs.google.com/spreadsheets/d/e/2PACX-1vQW643SM3iG2bKttgU-Benehh1kFUpWLXtyUZk5COs2wfkOX4ZYAQgJGb1xwlv0HqXqHzW7uJUsXmXb/pubhtml cuenta educa
//https://docs.google.com/spreadsheets/d/e/2PACX-1vTZ6TG0L-jHSXVCDuy8YJCr0L1qrhSc7yxcA9XOIdxfpvSPLGTKGmrwKR9gDOm6mWfVEsJukWknXqX0/pubhtml mi cuenta

//Versión 1 del 23 oct 2024, 16:56
//ID de implementación
//AKfycbyrpQ4a9FC1cPw5XJLbisGIE2YGMkmqhWDesAdLqZREymkoElQt0lRcdQYNzfEZxBEB
//Aplicación web
//URL
//https://script.google.com/macros/s/AKfycbyrpQ4a9FC1cPw5XJLbisGIE2YGMkmqhWDesAdLqZREymkoElQt0lRcdQYNzfEZxBEB/exec
//https://script.google.com/macros/s/AKfycbyrpQ4a9FC1cPw5XJLbisGIE2YGMkmqhWDesAdLqZREymkoElQt0lRcdQYNzfEZxBEB/exec?spreadsheetId=1p5gLnar8Un2DHa1QtP0Nvod6jyExvdJ3bZnfwUePsa4&sheet=users
//https://script.google.com/macros/s/AKfycbwDv0d_GQWzGZrXD2V7b_ycX7DGSNk9i3Sw9g7wfxoHq8m-fhczTZTsr8k15CQcYlrU/exec?spreadsheetId=1p5gLnar8Un2DHa1QtP0Nvod6jyExvdJ3bZnfwUePsa4&sheet=usuarios
