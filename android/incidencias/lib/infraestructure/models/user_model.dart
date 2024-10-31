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
