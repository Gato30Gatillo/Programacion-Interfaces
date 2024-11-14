import 'dart:convert';

Incidencias incidenciaFromJson(String str) => Incidencias.fromJson(json.decode(str));

String incidenciaToJson(Incidencias data) => json.encode(data.toJson());

class Incidencias {
    final int id;
    final String numeroAula;
    final String nombreProfesor;
    final String fechaIncidencia;
    final String descripcionIncidencia;
    final String status;

    Incidencias({
        required this.id,
        required this.numeroAula,
        required this.nombreProfesor,
        required this.fechaIncidencia,
        required this.descripcionIncidencia,
        required this.status,
    });

    factory Incidencias.fromJson(Map<String, dynamic> json) => Incidencias(
        id: json["id"],
        numeroAula: json["numeroAula"],
        nombreProfesor: json["nombreProfesor"],
        fechaIncidencia: (json["fechaActual"]),
        descripcionIncidencia: json["descripcionIncidencia"],
        status: json["status"],
    );

    Map<String, dynamic> toJson() => {
        "id": id,
        "numeroAula": numeroAula,
        "nombreProfesor": nombreProfesor,
        "fechaActual": fechaIncidencia,
        "descripcionIncidencia": descripcionIncidencia,
        "status": status,
    };

    static List<Incidencias> fromJsonList(List<dynamic> jsonList) {
        return jsonList.map((json) => Incidencias.fromJson(json)).toList();
  }
}