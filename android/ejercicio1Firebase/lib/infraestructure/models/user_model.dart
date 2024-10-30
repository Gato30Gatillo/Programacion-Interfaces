//import 'package:ejercicio1/domain/entities/user.dart';

import 'dart:convert';

List<UserModel> userModelFromJson(String str) =>
    List<UserModel>.from(json.decode(str).map((x) => UserModel.fromJsonMap(x)));

String userModelToJson(List<UserModel> data) =>
    json.encode(List<dynamic>.from(data.map((x) => x.toJson())));

class UserModel {
  String email;

  UserModel({
    required this.email,
  });

  factory UserModel.fromJsonMap(Map<String, dynamic> json) {
    return UserModel(
      email: json["email"],
    );
  }

  Map<String, dynamic> toJson() => {
        "email": email,
      };
}
/*
List<UserModel> userModelFromJson(String str) => List<UserModel>.from(json.decode(str).map((x) => UserModel.fromJson(x)));

String userModelToJson(List<UserModel> data) => json.encode(List<dynamic>.from(data.map((x) => x.toJson())));

class UserModel {
    String id;
    String correo;
    String clave;

    UserModel({
        required this.id,
        required this.correo,
        required this.clave,
    });

    factory UserModel.fromJson(Map<String, dynamic> json) => UserModel(
        id: json["id"],
        correo: json["correo"],
        clave: json["clave"],
    );

    Map<String, dynamic> toJson() => {
        "id": id,
        "correo": correo,
        "clave": clave,
    };
}
*/