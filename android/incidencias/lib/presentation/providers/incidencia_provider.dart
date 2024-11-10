import 'package:ejercicio1/infraestructure/models/incidenciaModel.dart';
import 'package:flutter/material.dart';

import '../../config/helpers/get_incidencia_model.dart';

class IncidenciasProvider extends ChangeNotifier {

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

  void addIncidencia(Incidencias incidencia) {
    incidencias.add(incidencia);
    notifyListeners();

  }

}
