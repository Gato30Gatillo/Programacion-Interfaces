import 'package:country/domain/entities/country.dart';
import 'package:flutter/material.dart';

class CountryBubble extends StatelessWidget {
  const CountryBubble({super.key, required this.country});


  final Country country;
  
  @override
  Widget build(BuildContext context) {
    
    final colors= Theme.of(context).colorScheme;
    

    return Column(
      crossAxisAlignment: CrossAxisAlignment.center,
      children: [
        Container(
          decoration: BoxDecoration(
            color: colors.secondary,
            borderRadius: BorderRadius.circular(20)
          ),
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 10),
            child: Text(
              country.capital, 
              style: const TextStyle(color: Colors.white),
              ),
          ),
        ),
        const SizedBox(height: 10),

        _ImageBubble(imageUrl: country.imageUrl)
      ],
    );
  }
}

class _ImageBubble extends StatelessWidget {
  final String imageUrl;
  const _ImageBubble({required this.imageUrl});

  @override
  Widget build(BuildContext context) {
    return ClipRRect(
    borderRadius: BorderRadius.circular(100),
    child: Image.network(imageUrl,
    fit: BoxFit.fill,
    ));
  }
  }