import 'package:country/config/helpers/countriesapi.dart';
import 'package:country/domain/entities/country.dart';
import 'package:flutter/material.dart';

class CountryProvider extends ChangeNotifier {


  List<Country> countryList=[
    Country(
      nombre: "placeholder", 
      imageUrl: "placeholder",
      capital: "placeholder"
      )];
  final CountriesApi countries = CountriesApi();
  // late final Country pais1;

  Future<void> reply(String nombre)async{
    final pais = await countries.getAnswer(nombre);
    countryList.clear();
    countryList.add(pais);
    // pais1.nombre=pais.nombre;
    // pais1.imageUrl=pais.imageUrl;
    // pais1.capital=pais.capital;
    notifyListeners();
   }

}