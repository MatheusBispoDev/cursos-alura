import 'dart:async';
import 'package:flutter/material.dart';
import 'package:flutterwebapi/http/webclients/transaction_webclient.dart';
import 'package:flutterwebapi/models/contact.dart';
import 'package:flutterwebapi/models/transaction.dart';
import 'package:flutterwebapi/widgets/progress.dart';
import 'package:flutterwebapi/widgets/response_dialog.dart';
import 'package:flutterwebapi/widgets/transaction_auth_dialog.dart';
import 'package:uuid/uuid.dart';

class TransactionForm extends StatefulWidget {
  final Contact contact;

  TransactionForm(this.contact);

  @override
  _TransactionFormState createState() => _TransactionFormState();
}

class _TransactionFormState extends State<TransactionForm> {
  final TextEditingController _valueController = TextEditingController();
  final TransactionWebClient _webClient = TransactionWebClient();
  final String transactionId = Uuid().v4();
  bool _sending = false;

  @override
  Widget build(BuildContext context) {
    print(transactionId);
    return Scaffold(
      appBar: AppBar(
        title: Text('New transaction'),
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.all(16.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: <Widget>[
              Text(
                widget.contact.name,
                style: TextStyle(
                  fontSize: 24.0,
                ),
              ),
              Padding(
                padding: const EdgeInsets.only(top: 16.0),
                child: Text(
                  widget.contact.accountNumber.toString(),
                  style: TextStyle(
                    fontSize: 32.0,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),
              Padding(
                padding: const EdgeInsets.only(top: 16.0),
                child: TextField(
                  controller: _valueController,
                  style: TextStyle(fontSize: 24.0),
                  decoration: InputDecoration(labelText: 'Value'),
                  keyboardType: TextInputType.numberWithOptions(decimal: true),
                ),
              ),
              Padding(
                padding: const EdgeInsets.only(top: 16.0),
                child: SizedBox(
                  width: double.maxFinite,
                  child: ElevatedButton(
                    child: Text('Transfer'),
                    onPressed: () {
                      final value = double.tryParse(_valueController.text);
                      final Transaction transactionCreated = Transaction(
                          transactionId,
                          value != null ? value : 0,
                          widget.contact);
                      showDialog(
                          context: context,
                          builder: (contextDialog) => TransactionAuthDialog(
                                //Precisa mudar o nome do context do builder, para que consiga fechar a tela corretamente
                                onConfirm: (String password) {
                                  _save(transactionCreated, password, context);
                                },
                              ));
                    },
                  ),
                ),
              ),
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Visibility(
                  child: Progress(message: 'Enviando'),
                  visible: _sending,
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  Future<void> _save(Transaction transactionCreated, String password,
      BuildContext context) async {
    setState(() {
      _sending = true;
    });
    Transaction transaction = await _sendWebApi(
        transactionCreated, password, context); //Tratamento timeout
    //test = só executa se for uma Exception mesmo

    _showMessageSucess(transaction, context);
  }

  Future<void> _showMessageSucess(
      Transaction transaction, BuildContext context) async {
    await showDialog(
        context: context,
        builder: (contextDialog) {
          return SuccessDialog('sucessful transaction');
        });
    Navigator.pop(context);
    //Necessário o parâmetro
  }

  Future<Transaction> _sendWebApi(Transaction transactionCreated,
      String password, BuildContext context) async {
    final Transaction transaction =
        await _webClient.save(transactionCreated, password).catchError((e) {
      //Tratamento de erros especificos
      _showFailureMessage(context, message: e.message);
    }, test: (e) => e is Exception).catchError((e) {
      //Tratamento de erros especifios (timeout)
      _showFailureMessage(context,
          message: 'timeout submitting the transaction');
    }, test: (e) => e is TimeoutException).catchError((e) {
      //Tratamento de erros genericos (qualquer erro) - Sempre precisa ser a última exception
      _showFailureMessage(context);
    }).whenComplete(() { //Vai ser executada quando finalizar
      setState(() {
        _sending = false;
      });
    }); //Tratamento timeout
    //test = só executa se for uma Exception mesmo

    return transaction;
  }

  void _showFailureMessage(BuildContext context,
      {String message = 'Unkown error'}) {
    showDialog(
        context: context,
        builder: (contextDialog) {
          return FailureDialog(message);
        });
  }
}
