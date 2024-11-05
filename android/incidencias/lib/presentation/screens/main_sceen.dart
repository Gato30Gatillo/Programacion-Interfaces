import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class MainSceen extends StatelessWidget {
  const MainSceen({super.key, this.email});

  static const name = 'main_screen';
  final String? email;

  @override
  Widget build(BuildContext context) {
    final textControlerAula = TextEditingController();
    final textControlerProfesor = TextEditingController();
    final textControlerFecha = TextEditingController(
      text: DateFormat('yyyy-MM-dd').format(DateTime.now()),//valor base. Necesita una dependencia intl: ^0.17.0
    );
    final textControlerDesc = TextEditingController();
    final size= MediaQuery.of(context).size;

    return Scaffold(
      appBar: AppBar(
        centerTitle: true,
        title: Text("Bienvenido $email"),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back),
          onPressed: () => {},
        ),
      ),
      body: Center(
        child: SizedBox(
          width: size.width*0.8, 
          height: size.height*0.8, 
          child: Container(
            padding: const EdgeInsets.all(16.0),
            decoration: BoxDecoration(
              color: Colors.grey[200],
              borderRadius: BorderRadius.circular(15),
              boxShadow: [
                BoxShadow(
                  color: Colors.black.withOpacity(0.1),
                  blurRadius: 10,
                  offset: const Offset(0, 5),
                ),
              ],
            ),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                const Text("Número de aula"),
                const SizedBox(height: 16),
                TextFormField(
                  controller: textControlerAula,
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                  ),
                ),
                const SizedBox(height: 16),
                const Text("Nombre del profesor que registra la incidencia"),
                const SizedBox(height: 16),
                TextFormField(
                  controller: textControlerProfesor,
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                  ),
                ),
                const SizedBox(height: 16),
                const Text("Fecha de detección de la incidencia"),
                const SizedBox(height: 16),
                TextFormField(
                  controller: textControlerFecha,
                  readOnly: true, // Hace que el campo sea de solo lectura
                  onTap: () async {
                    DateTime? pickedDate = await showDatePicker(
                      context: context,
                      initialDate: DateTime.now(),
                      firstDate: DateTime(2000),
                      lastDate: DateTime(2100),
                    ); //nos permite ver el calendario y seleccionar en el
                    if (pickedDate != null) {
                      // Formatea la fecha elegida y la muestra en el campo de texto
                      String formattedDate = "${pickedDate.year}-${pickedDate.month.toString().padLeft(2, '0')}-${pickedDate.day.toString().padLeft(2, '0')}";
                      textControlerFecha.text = formattedDate;
                    }
                  },
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                    suffixIcon: Icon(Icons.calendar_today),
                  ),
                ),
                const SizedBox(height: 16),
                const Text("Descripción de la incidencia"),
                const SizedBox(height: 16),
                TextFormField(
                  controller: textControlerDesc,
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                  ),
                ),
                const SizedBox(height: 16),
                Center(
                  child: ElevatedButton.icon(
                    onPressed: () {},
                    icon: const Icon(Icons.send),
                    label: const Text("Enviar"),
                    style: ElevatedButton.styleFrom(
                      backgroundColor: Colors.red,
                      padding: const EdgeInsets.symmetric(vertical: 10, horizontal: 20),
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(10),
                      ),
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
