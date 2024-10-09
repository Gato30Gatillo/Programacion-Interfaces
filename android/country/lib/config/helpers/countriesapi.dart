import 'package:country/domain/entities/country.dart';
import 'package:country/infraestructura/models/countrymodel.dart';
import 'package:dio/dio.dart';

class CountriesApi {
  final dio=Dio();

  Future<Country> getAnswer()async{
    final response = await dio.get("https://restcountries.com/v3.1/name/"); 

    if(response.statusCode==200){
        final countrymodel= CountryModel.fromJsonMap(response.data);
        return countrymodel;
    }

    throw UnimplementedError();
  }
}