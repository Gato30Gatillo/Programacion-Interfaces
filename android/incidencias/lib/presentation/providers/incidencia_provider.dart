import 'package:dio/dio.dart';
import 'package:ejercicio1/infraestructure/models/incidenciaModel.dart';
import 'package:ejercicio1/infraestructure/models/incidenciaModelEnviar.dart';
import 'package:flutter/material.dart';

import '../../config/helpers/get_incidencia_model.dart';

class IncidenciasProvider extends ChangeNotifier {

  final _dio=Dio();
  List<Incidencias> incidencias=[
    Incidencias(
      id: 0, 
      numeroAula: "numeroAula", 
      nombreProfesor: "nombreProfesor", 
      fechaIncidencia: "fechaIncidencia", 
      descripcionIncidencia: "descripcionIncidencia", 
      status: "status")
  ];

  Future<void> getIncidencias()async{
    final response = await GetIncidenciasModel().getAnswer();
    incidencias.addAll(response);
    notifyListeners();

  }

  Future<void> addIncidencia(IncidenciasEnviar incidencia) async {
    FormData formData = FormData.fromMap(incidencia.toJson());
    await _dio.post("http://localhost:8081/incidenciasTic/crear_incidencia",
    data: formData,
    options: Options(contentType: "multipart/form-data"));
  }

}
