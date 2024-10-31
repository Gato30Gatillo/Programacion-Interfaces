import 'package:ejercicio1/infraestructure/models/user_model.dart';
import 'package:flutter/material.dart';

class LoginProvider extends ChangeNotifier {

  List<UserModel> usuarios=[];

  Future<void> getUsuarios()async{

   notifyListeners();

  }

}
