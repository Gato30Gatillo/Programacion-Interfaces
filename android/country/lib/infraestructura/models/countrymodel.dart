// To parse this JSON data, do
//
//     final country = countryFromJson(jsonString);

import 'dart:convert';

import 'package:country/domain/entities/country.dart';

CountryModel countryFromJson(String str) => CountryModel.fromJsonMap(json.decode(str));

String countryToJson(CountryModel data) => json.encode(data.toJson());

class CountryModel {
    Name name;
    List<String> capital;
    Flags flags;
    

    CountryModel({
        required this.name,
        required this.capital,
        required this.flags,

    });

    factory CountryModel.fromJsonMap(Map<String, dynamic> json) => CountryModel(
        name: Name.fromJson(json["name"]),
        capital: List<String>.from(json["capital"].map((x) => x)),
        flags: Flags.fromJson(json["flags"]),

    );

    Map<String, dynamic> toJson() => {
        "name": name.toJson(),
        "capital": List<dynamic>.from(capital.map((x) => x)),
        "flags": flags.toJson(),

    };

    Country toMessageEntity() => Country(
      nombre: name.official, 
      imageUrl: flags.png,
      capital: capital.first,
      );
}

class Flags {
    String png;
    String svg;
    String alt;

    Flags({
        required this.png,
        required this.svg,
        required this.alt,
    });

    factory Flags.fromJson(Map<String, dynamic> json) => Flags(
        png: json["png"],
        svg: json["svg"],
        alt: json["alt"],
    );

    Map<String, dynamic> toJson() => {
        "png": png,
        "svg": svg,
        "alt": alt,
    };
}

class Languages {
    String spa;
    String cat;
    String eus;
    String glc;

    Languages({
        required this.spa,
        required this.cat,
        required this.eus,
        required this.glc,
    });

    factory Languages.fromJson(Map<String, dynamic> json) => Languages(
        spa: json["spa"],
        cat: json["cat"],
        eus: json["eus"],
        glc: json["glc"],
    );

    Map<String, dynamic> toJson() => {
        "spa": spa,
        "cat": cat,
        "eus": eus,
        "glc": glc,
    };
}

class Name {
    String common;
    String official;
    NativeName nativeName;

    Name({
        required this.common,
        required this.official,
        required this.nativeName,
    });

    factory Name.fromJson(Map<String, dynamic> json) => Name(
        common: json["common"],
        official: json["official"],
        nativeName: NativeName.fromJson(json["nativeName"]),
    );

    Map<String, dynamic> toJson() => {
        "common": common,
        "official": official,
        "nativeName": nativeName.toJson(),
    };
}

class NativeName {
    Translation nameTranslator;

    NativeName({
        required this.nameTranslator,
    });

    factory NativeName.fromJson(Map<String, dynamic> json) => NativeName(
        nameTranslator: Translation.fromJson(json[json.keys.first]),
    );

    Map<String, dynamic> toJson() => {
        "spa": nameTranslator.toJson(),
    };
}

class Translation {
    String official;
    String common;

    Translation({
        required this.official,
        required this.common,
    });

    factory Translation.fromJson(Map<String, dynamic> json) => Translation(
        official: json["official"],
        common: json["common"],
    );

    Map<String, dynamic> toJson() => {
        "official": official,
        "common": common,
    };
}