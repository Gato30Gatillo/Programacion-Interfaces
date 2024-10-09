import 'package:country/infraestructura/models/countrymodel.dart';

class Country {
  final Name name;
  final Flags imageUrl;
  final String capital;

Country({
  required this.name,
  required this.imageUrl,
  required this.capital,
});
}