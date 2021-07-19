import 'dart:convert';
import 'package:flutterwebapi/http/web_client.dart';
import 'package:flutterwebapi/models/contact.dart';
import 'package:flutterwebapi/models/transaction.dart';
import 'package:http/http.dart';

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           Segundo cóidgo                                                                                                  //
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

class TransactionWebClient {
  Future<List<Transaction>> findAll() async {
    //final Response response = await client.get(Uri.https('035d9fbb1ea9.ngrok.io', 'transactions')); //Endereço gerado pelo ngrok
    final Response response = await client
        .get(Uri.parse(baseUrl))
        .timeout(Duration(seconds: 5)); //Endereço gerado pelo ngrok

    List<Transaction> transactions = _toTransactions(response);
    return transactions;
  }

  List<Transaction> _toTransactions(Response response) {
    //Conversão para json para lista dynamica
    final List<dynamic> decodedJson = jsonDecode(response.body);
    //Criou uma lista para armazenar transactions(Model)
    final List<Transaction> transactions = [];

    //For ade Map até o final da repostas da web API
    //Cria uma transacion, com o valor do contato com base em json
    //['contact'] = grupo ['contact']['name'] = atributo
    for (Map<String, dynamic> transactionJson in decodedJson) {
      //transactions.add(Transaction.fromJson(transactionJson));
      //Código acima: Conversão por meio da classe (refatoração de código)
      //Código abaixo: Conversão de json para transacion
      final Map<String, dynamic> contactJson = transactionJson['contact'];
      final Transaction transaction = Transaction(
        transactionJson['id'],
        transactionJson['value'],
        Contact(
          0,
          contactJson['name'],
          contactJson['accountNumber'],
        ),
      );
      transactions.add(transaction); //Adiciona a lista criada para retornar
    }
    return transactions;
  }

  Future<Transaction> save(Transaction transaction, String password) async {
    //final transactionJson = jsonEncode(transaction.toJson());
    Map<String, dynamic> transactionMap = __toMap(transaction);
    final transactionJson = jsonEncode(transactionMap);

    await Future.delayed(Duration(seconds: 2));

    final Response response = await client
        .post(
          Uri.parse(baseUrl),
          headers: {
            'Content-type': 'application/json',
            'password': password,
          },
          body: transactionJson,
        )
        .timeout(Duration(seconds: 5));

    if (response.statusCode != 200) {
      throw HttpException(_getMessage(response.statusCode));
    }

    return _toTransaction(response);
  }

  String? _getMessage(int statusCode){
    if(_statusCodeResponses.containsKey(statusCode)){
      return _statusCodeResponses[statusCode];
    }
    return 'Unknows error';
  }

  //Criando um mapa para armazenar as respostas da Api
  static final Map<int, String> _statusCodeResponses = {
    400: 'There was an error submitting transaction',
    401: 'authentication failed',
    409: 'transaction always exists',
  };

  Transaction _toTransaction(Response response) {
    Map<String, dynamic> json = jsonDecode(response.body);
    final Map<String, dynamic> contactJson = json['contact'];
    return //Transaction.fromJson(json);
        Transaction(
      json['id'],
      json['value'],
      Contact(
        0,
        contactJson['name'],
        contactJson['accountNumber'],
      ),
    );
  }

  Map<String, dynamic> __toMap(Transaction transaction) {
    final Map<String, dynamic> transactionMap = {
      'value': transaction.value,
      'contact': {
        'name': transaction.contact.name,
        'accountNumber': transaction.contact.accountNumber,
      }
    };
    return transactionMap;
  }
}

class HttpException implements Exception {
  final String? message;

  HttpException(this.message);
}

//
// class TransactionWebClient {
//   Future<List<Transaction>> findAll() async {
//     final Response response =
//     await client.get(Uri.parse(baseUrl)).timeout(Duration(seconds: 5));
//     final List<dynamic> decodedJson = jsonDecode(response.body);
//     return decodedJson
//         .map((dynamic json) =>
//         Transaction.fromJson(json)) //Retorna uma transferencia de json
//         .toList();
//   }
//
//   Future<Transaction> save(Transaction transaction) async {
//     final String transactionJson = jsonEncode(transaction.toJson());
//
//     final Response response = await client.post(Uri.parse(baseUrl),
//         headers: {
//           'Content-type': 'application/json',
//           'password': '1000',
//         },
//         body: transactionJson);
//
//     return Transaction.fromJson(jsonDecode(response.body));
//   }
// }
