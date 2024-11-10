import 'package:dio/dio.dart';

class GetIncidenciasModel {
  final _dio=Dio();

  Future getAnswer()async{
    final response = await _dio.get("http://localhost:8081/incidenciasTic/mostrar_incidencias"); 
    if(response.statusCode==200){
        return response.data;
    }
    else{
      print("mal dio");
    }

    throw UnimplementedError();
  }
}