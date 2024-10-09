import 'package:flutter/material.dart';
import 'package:yes_no_app/domain/entities/message.dart';

class HermessageBubble extends StatelessWidget {
  const HermessageBubble({super.key, required this.message});


  final Message message;
  
  @override
  Widget build(BuildContext context) {
    
    final colors= Theme.of(context).colorScheme;
    

    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Container(
          decoration: BoxDecoration(
            color: colors.secondary,
            borderRadius: BorderRadius.circular(20)
          ),
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 10),
            child: Text(
              message.text, 
              style: const TextStyle(color: Colors.white),
              ),
          ),
        ),
        const SizedBox(height: 10),

        _ImageBubble(imageUrl: message.imageUrl)
      ],
    );
  }
}

class _ImageBubble extends StatelessWidget {
  final String? imageUrl;
  const _ImageBubble({required this.imageUrl});

  @override
  Widget build(BuildContext context) {
    final size= MediaQuery.of(context).size;
    return ClipRRect(
    borderRadius: BorderRadius.circular(100),
    child: Image.network(imageUrl!,
    //width: size.width*0.3,
    //height: size.height*0.2,
    fit: BoxFit.fill,
    loadingBuilder: (context,child, loadingProgress){
      //if(loadingProgress==null) return child;
      return SizedBox(
        width: size.width*0.3,
        height: size.height*0.5,
        child: const Center(
          child: CircularProgressIndicator(),)

    );
    
  }
    ));
  }
  }