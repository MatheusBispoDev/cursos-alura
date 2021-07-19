import 'package:flutterwebapi/database/app_database.dart';
import 'package:flutterwebapi/models/contact.dart';
import 'package:sqflite/sqflite.dart';

class ContactDao {
  static const String _tabeleaName = 'contacts';
  static const String _id = 'id';
  static const String _nome = 'name';
  static const String _accountNumber = 'account_number';
  static const String tableSql = 'CREATE TABLE $_tabeleaName('
      'id INTEGER PRIMARY KEY, '
      'name TEXT, '
      'account_number INTEGER)';

  Future<int> save(Contact contact) async {
    final Database db = await getDatabase(tableSql);
    Map<String, dynamic> contactMap = _toMap(contact);
    return db.insert(_tabeleaName, contactMap);
  }

  Map<String, dynamic> _toMap(Contact contact) {
    final Map<String, dynamic> contactMap = Map();
    //contactMap['id'] = contact.id; Se tirar o id o sqlite incrementa automaticamente se for inteiro
    contactMap[_nome] = contact.name;
    contactMap[_accountNumber] = contact.accountNumber;
    return contactMap;
  }

//Pegar todos os contatos
  Future<List<Contact>> findAll() async {
    final Database db = await getDatabase(tableSql);
    final List<Map<String, dynamic>> result = await db.query(_tabeleaName);
    List<Contact> contacts = _toList(result);
    return contacts;
  }

  List<Contact> _toList(List<Map<String, dynamic>> result) {
    final List<Contact> contacts = [];

    for (Map<String, dynamic> row in result) {
      final Contact contact = Contact(
        row[_id],
        row[_nome],
        row[_accountNumber],
      );
      contacts.add(contact);
    }
    return contacts;
  }

  Future<int> delete(int id) async {
    final db = await getDatabase(tableSql);

    int resultado = await db.delete(
      _tabeleaName,
      where: 'id = ?',
      whereArgs: [id],
    );
    return resultado;
  }
}



