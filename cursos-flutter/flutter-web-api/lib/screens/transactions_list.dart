import 'package:flutter/material.dart';
import 'package:flutterwebapi/http/webclients/transaction_webclient.dart';
import 'package:flutterwebapi/models/transaction.dart';
import 'package:flutterwebapi/widgets/centered_message.dart';
import 'package:flutterwebapi/widgets/progress.dart';

class TransactionsList extends StatefulWidget {
  @override
  _TransactionsListState createState() => _TransactionsListState();
}

class _TransactionsListState extends State<TransactionsList> {
  final TransactionWebClient _webClient = TransactionWebClient();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Transactions'),
      ),
      body: FutureBuilder<List<Transaction>>(
        // future: Future.delayed(Duration(seconds: 1)).then((value) => findAll()),
        future: _webClient.findAll(),
        builder: (context, snapshot) {
          switch (snapshot.connectionState) {
            case ConnectionState.none:
              break;
            case ConnectionState.waiting:
              return Progress(message: "Carregando");
            case ConnectionState.active:
              break;
            case ConnectionState.done:
              final List<Transaction>? transactions = snapshot.data;

              if(snapshot.hasData){
                if (transactions != null && transactions.isNotEmpty) {
                  return ListView.builder(
                    itemBuilder: (context, index) {
                      final Transaction transaction = transactions[index];
                      return Card(
                        child: ListTile(
                          leading: Icon(Icons.monetization_on),
                          title: Text(
                            transaction.value.toString(),
                            style: TextStyle(
                              fontSize: 24.0,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          subtitle: Text(
                            transaction.contact.accountNumber.toString(),
                            style: TextStyle(
                              fontSize: 16.0,
                            ),
                          ),
                        ),
                      );
                    },
                    itemCount: transactions.length,
                  );
                }
                return CenteredMessage('No transactions found', icon: Icons.warning);
              }
              break;
          }
          return CenteredMessage('Error', icon: Icons.error_outline);
        },
      ),
    );
  }
}
