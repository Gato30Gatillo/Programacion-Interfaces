import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:iseneca/models/models.dart';
import 'package:iseneca/providers/providers.dart';
import 'package:iseneca/service/services.dart';
import 'package:provider/provider.dart';

class IncidenciasScreen extends StatefulWidget {
  const IncidenciasScreen({super.key, this.email});

  static const name = 'incidencias_screen';
  final String? email;

  @override
  _IncidenciasScreenState createState() => _IncidenciasScreenState();
}

class _IncidenciasScreenState extends State<IncidenciasScreen> {
  String? email; 
  final textControlerAula = TextEditingController();
  final textControlerProfesor = TextEditingController();
  final textControlerFecha = TextEditingController(
    text: DateFormat('yyyy-MM-dd').format(DateTime.now()),
  );
  final textControlerDesc = TextEditingController();
  late Future<void> _incidenciasFuture;
  bool adminMode=false;


  @override
  void initState() {
    super.initState();
    final provider = context.read<IncidenciasProvider>();
    _incidenciasFuture = provider.getIncidencias();
  }

  @override
  Widget build(BuildContext context) {
    final size = MediaQuery.of(context).size;
    final provider = context.watch<IncidenciasProvider>();
    email=FirebaseAuth.instance.currentUser?.email;
    email ??= "jesus27044@gmail.com";
    textControlerProfesor.text=email!;
    
    return Scaffold(
      appBar: AppBar(
        centerTitle: true,
        title: Text("Bienvenido $email"),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back),
          onPressed: () => {
            Navigator.pushNamed(context, "main_screen")
          },
        ),
      ),
      body: SingleChildScrollView(
        child: Center(
          child: Column(
            children: [
              FormularioIncidencias(size, context, provider),
              const SizedBox(height: 16),
              // Lista de incidencias
              ListaIncidencias(incidenciasFuture: _incidenciasFuture, size: size)
            ],
          ),
        ),
      ),
    );
  }

  SizedBox FormularioIncidencias(Size size, BuildContext context, IncidenciasProvider provider) {
    if(!adminMode){
    return SizedBox(
      width: size.width * 0.8,
      height: size.height * 0.8,
      child: Container(
        padding: const EdgeInsets.all(16.0),
        decoration: BoxDecoration(
          color: Colors.grey,
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
            const Text("profesor que registra la incidencia"),
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
              readOnly: true,
              onTap: () async {
                DateTime? pickedDate = await showDatePicker(
                  context: context,
                  initialDate: DateTime.now(),
                  firstDate: DateTime(2000),
                  lastDate: DateTime(2100),
                );
                if (pickedDate != null) {
                  String formattedDate =
                      "${pickedDate.year}-${pickedDate.month.toString().padLeft(2, '0')}-${pickedDate.day.toString().padLeft(2, '0')}";
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
                onPressed: () {
                  provider.addIncidencia(
                    IncidenciasEnviar(
                      numeroAula: textControlerAula.text,
                      nombreProfesor: textControlerProfesor.text,
                      descripcionIncidencia: textControlerDesc.text,
                      fechaIncidencia: textControlerFecha.text,
                    ),
                  );
                  textControlerDesc.clear();
                  textControlerProfesor.text=email!;
                  textControlerAula.clear();
                  textControlerFecha.text =
                      DateFormat('yyyy-MM-dd').format(DateTime.now());
                  setState(() {
                    _incidenciasFuture = provider.getIncidencias();
                  });
                },
                icon: const Icon(Icons.send),
                label: const Text("Enviar"),
                style: ElevatedButton.styleFrom(
                  backgroundColor: Colors.red,
                  padding: const EdgeInsets.symmetric(
                      vertical: 10, horizontal: 20),
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(10),
                  ),
                ),
              ),
            ),
          ],
        ),
      ),
    );
    }
    else{
     return SizedBox(
        width: size.width * 0.8,
        height: size.height * 0.8,
        child: Container(
          padding: const EdgeInsets.all(16.0),
          decoration: BoxDecoration(
            color: Colors.grey,
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
              const Text("profesor que registra la incidencia"),
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
                readOnly: true,
                onTap: () async {
                  DateTime? pickedDate = await showDatePicker(
                    context: context,
                    initialDate: DateTime.now(),
                    firstDate: DateTime(2000),
                    lastDate: DateTime(2100),
                  );
                  if (pickedDate != null) {
                    String formattedDate =
                        "${pickedDate.year}-${pickedDate.month.toString().padLeft(2, '0')}-${pickedDate.day.toString().padLeft(2, '0')}";
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
                  onPressed: () {
                    IncidenciasEnviar enviar= IncidenciasEnviar(
                        numeroAula: textControlerAula.text,
                        nombreProfesor: textControlerProfesor.text,
                        descripcionIncidencia: textControlerDesc.text,
                        fechaIncidencia: textControlerFecha.text,
                      );
                    provider.searchIncidencia(
                      enviar,
                    );
                    textControlerDesc.clear();
                    textControlerProfesor.text=email!;
                    textControlerAula.clear();
                    textControlerFecha.text =
                        DateFormat('yyyy-MM-dd').format(DateTime.now());
                    setState(() {
                      _incidenciasFuture = provider.searchIncidencia(enviar);
                    });
                  },
                  icon: const Icon(Icons.send),
                  label: const Text("Buscar"),
                  style: ElevatedButton.styleFrom(
                    backgroundColor: Colors.red,
                    padding: const EdgeInsets.symmetric(
                        vertical: 10, horizontal: 20),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10),
                    ),
                  ),
                ),
              ),
            ],
          ),
        ),
      );
    }
  }
}



class ListaIncidencias extends StatelessWidget {
  const ListaIncidencias({
    super.key,
    required Future<void> incidenciasFuture,
    required this.size,
  }) : _incidenciasFuture = incidenciasFuture;

  final Future<void> _incidenciasFuture;
  final Size size;

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
      future: _incidenciasFuture,
      builder: (context, snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const CircularProgressIndicator();
        }
        if (snapshot.connectionState == ConnectionState.done) {
          return Consumer<IncidenciasProvider>(
            builder: (context, provider, _) => SizedBox(
              height: size.height * 0.6,
              width: size.width * 0.8,
              child: ListView.builder(
                padding: const EdgeInsets.all(16.0),
                itemCount: provider.incidencias.length,
                itemBuilder: (context, index) {
                  final incidencia = provider.incidencias[index];
                  return Card(
                    margin:
                        const EdgeInsets.symmetric(vertical: 8.0),
                    child: ListTile(
                      title: Text("Aula: ${incidencia.numeroAula}"),
                      subtitle: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(
                              "Profesor: ${incidencia.nombreProfesor}"),
                          Text(
                              "Fecha: ${incidencia.fechaIncidencia}"),
                          Text(
                              "Descripción: ${incidencia.descripcionIncidencia}"),
                          Text("Estado: ${incidencia.status}"),
                        ],
                      ),
                      isThreeLine: true,
                    ),
                  );
                },
              ),
            ),
          );
        }
        return const CircularProgressIndicator();
      },
    );
  }
}