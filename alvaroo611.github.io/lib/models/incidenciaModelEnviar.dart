import 'dart:convert';

IncidenciasEnviar incidenciaEnviarFromJson(String str) => IncidenciasEnviar.fromJson(json.decode(str));

String incidenciaEnviarToJson(IncidenciasEnviar data) => json.encode(data.toJson());

class IncidenciasEnviar {
    final String numeroAula;
    final String nombreProfesor;
    final String fechaIncidencia;
    final String descripcionIncidencia;

    IncidenciasEnviar({
        required this.numeroAula,
        required this.nombreProfesor,
        required this.fechaIncidencia,
        required this.descripcionIncidencia,
    });

    factory IncidenciasEnviar.fromJson(Map<String, dynamic> json) => IncidenciasEnviar(
        numeroAula: json["numeroAula"],
        nombreProfesor: json["nombreProfesor"],
        fechaIncidencia: (json["fechaActual"]),
        descripcionIncidencia: json["descripcionIncidencia"],
    );

    Map<String, dynamic> toJson() => {
        "numeroAula": numeroAula,
        "nombreProfesor": nombreProfesor,
        "fechaActual": fechaIncidencia,
        "descripcionIncidencia": descripcionIncidencia,
    };

    static List<IncidenciasEnviar> fromJsonList(List<dynamic> jsonList) {
        return jsonList.map((json) => IncidenciasEnviar.fromJson(json)).toList();
  }
}