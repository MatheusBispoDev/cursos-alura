import 'package:path/path.dart';
import 'package:sqflite/sqflite.dart';

Future<Database> getDatabase(String createSql) async {
  //async tudo que será executado, será executado dentro de um Future
  final String path = join(await getDatabasesPath(),
      'bytebank.db'); //await segura até o join finalizar
  return openDatabase(
    path,
    onCreate: (db, version) {
      db.execute(createSql); //executa um comando SQL e cria tabela
    },
    version: 1,
  );
}
