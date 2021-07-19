import 'package:flutter/material.dart';
import 'package:flutterwebapi/database/DAO/contact_dao.dart';
import 'package:flutterwebapi/models/contact.dart';
import 'package:flutterwebapi/screens/contact_form.dart';
import 'package:flutterwebapi/screens/transaction_form.dart';
import 'package:flutterwebapi/widgets/progress.dart';

final ContactDao _dao = ContactDao();

class ContactsList extends StatefulWidget {
  @override
  _ContactsListState createState() => _ContactsListState();
}

class _ContactsListState extends State<ContactsList> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Transfer'),
      ),
      body: FutureBuilder<List<Contact>>(
          //FutureBuilder recebe um future como o stateful// Future do tipo lista de contatos
          initialData: [], //Dado inicial
          //future: Future.delayed(Duration(seconds: 1))
          //.then((value) => _dao.findAll()), //Executa o Future
          future: _dao.findAll(),
          builder: (context, snapshot) {
            //snapshot recebe o resultado do future no caso findAll()
            //Assim que tiver uma resposta executa o builder
            switch (snapshot.connectionState) {
              case ConnectionState.none:
                //Future ainda não foi executado
                //Botao para começar o Future
                break;
              case ConnectionState.waiting: //Ainda está carregando
                return Progress(message: "Carregando");
              case ConnectionState.active:
                //Tem um dado disponivel mas ainda não foi finalizado o Future
                //Serve para download, tras o valor que está pronto os dados
                break;
              case ConnectionState.done: //Quando estiver pronto
                final List<Contact>? contacts = snapshot.data;
                if (contacts != null) {
                  return ListView.builder(
                    itemBuilder: (context, index) {
                      final Contact contact = contacts[index];
                      return _ContactItem(
                        contact,
                        onClick: () {
                          Navigator.of(context).push(
                            MaterialPageRoute(
                                builder: (context) => TransactionForm(contact)),
                          );
                        },
                      );
                    },
                    itemCount: contacts.length,
                  );
                }
                break;
            }
            return Text('Unknown Error');
          }),
      floatingActionButton: FloatingActionButton(
        child: Icon(Icons.add),
        onPressed: () {
          Navigator.of(context)
              .push(
            MaterialPageRoute(builder: (context) => ContactForm()),
          )
              .then((value) {
            setState(() {});
          });
        },
      ),
    );
  }
}

class _ContactItem extends StatelessWidget {
  final Contact contact;
  final VoidCallback onClick; //VoidCallback = Function() ou void Function()

  _ContactItem(this.contact, {required this.onClick});

  @override
  Widget build(BuildContext context) {
    return Card(
      child: ListTile(
          title: Text(
            contact.name,
            style: TextStyle(fontSize: 24.0),
          ),
          onTap: onClick,
          subtitle: Text(
            contact.accountNumber.toString(),
            style: TextStyle(fontSize: 16.0),
          ),
          trailing: GestureDetector(
              child: Icon(Icons.delete),
              onTap: () {
                _dao.delete(contact.id);
              })),
    );
  }
}
