import 'package:flutter/material.dart';

class Progress extends StatelessWidget {
  final String message;

  Progress({this.message = 'Carregando'});

  @override
  Widget build(BuildContext context) {
    return Center(
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        crossAxisAlignment: CrossAxisAlignment.center,
        children: [
          CircularProgressIndicator(
            color: Colors.green,
          ),
          Padding(
            padding: const EdgeInsets.only(top: 8.0),
            child: Text(message, style: TextStyle(fontSize: 16),),
          ),
        ],
      ),
    );
  }
}
