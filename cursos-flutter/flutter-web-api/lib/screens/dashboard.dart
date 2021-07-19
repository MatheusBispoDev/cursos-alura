import 'package:flutter/material.dart';
import 'package:flutterwebapi/screens/contacts_list.dart';
import 'package:flutterwebapi/screens/transactions_list.dart';

class Dashboard extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Dashboard"),
      ),
      body: Column(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          /*Padding(
            padding: const EdgeInsets.all(16.0),
            child: Image.network(_urlimagem),
          ),*/
          Padding(
            padding: const EdgeInsets.all(16.0),
            child: Image.asset('images/bytebank_logo.png'),
          ),
          Container(
            height: 130,
            child: ListView(
              scrollDirection: Axis.horizontal,
              children: [
                _FeatureItem('Transfer', Icons.monetization_on,
                    onClick: () => _showContactsList(context)),
                _FeatureItem('Transaction Feed', Icons.description,
                    onClick: () => _showTransactionList(context)),
              ],
            ),
          ),
        ],
      ),
    );
  }

  void _showContactsList(BuildContext context) {
    Navigator.of(context)
        .push(MaterialPageRoute(builder: (context) => ContactsList()));
  }
}

void _showTransactionList(BuildContext context) {
  Navigator.of(context)
      .push(MaterialPageRoute(builder: (context) => TransactionsList()));
}

class _FeatureItem extends StatelessWidget {
  final String name;
  final IconData icon;
  final Function onClick;

  _FeatureItem(this.name, this.icon, {required this.onClick});

  //@required = precisa ser implementada

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: Material(
        //Material() Armazena a cor
        color: Theme.of(context).primaryColor,
        child: InkWell(
          //GestureDetector() do Material design
          onTap: () => onClick(),
          child: Container(
            padding: EdgeInsets.all(8.0),
            height: 120,
            width: 150,
            //color: Theme.of(context).primaryColor, //Pegar do primary color
            child: Column(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Icon(
                  icon,
                  color: Colors.white,
                  size: 32.0,
                ),
                Text(
                  name,
                  style: TextStyle(
                    color: Colors.white,
                    fontSize: 16.0,
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
