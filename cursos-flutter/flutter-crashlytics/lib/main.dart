import 'dart:async';
import 'package:alura_crashlytics/screens/dashboard.dart';
import 'package:flutter/material.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:firebase_crashlytics/firebase_crashlytics.dart';
import 'package:flutter/foundation.dart' show kDebugMode;

void main() async {

  WidgetsFlutterBinding.ensureInitialized();
  await Firebase.initializeApp();

  //kDebugMode verifica se o aplicativo está executando em modo desenvolvedor ou em produção
  if (kDebugMode) {
	//Caso seja desenvolvedor desativa o Crashlytics para evitar que os erros de desenvolvimento ocupo o Crashlytics
    await FirebaseCrashlytics.instance.setCrashlyticsCollectionEnabled(false);
  } else {
	//Caso seja em proução ativa o Crashlytics
    await FirebaseCrashlytics.instance.setCrashlyticsCollectionEnabled(true);
	//comando para passar o usuário logado quando ocorrer erro
    FirebaseCrashlytics.instance.setUserIdentifier('alura123');
	//Troca as analises de erros do Flutter para o Firebase (todos os erros de app serão pegos pelo Crashlytics)
    FlutterError.onError = FirebaseCrashlytics.instance.recordFlutterError;
  }

  //zona de erro: todos erros em nível Dart serão pegos
  runZonedGuarded<Future<void>>(() async {
    runApp(BytebankApp());
  }, FirebaseCrashlytics.instance.recordError);

}

class BytebankApp extends StatelessWidget {

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      theme: ThemeData(
        primaryColor: Colors.green[900],
        accentColor: Color.fromRGBO(71, 161, 56, 1),
        buttonTheme: ButtonThemeData(
          buttonColor: Color.fromRGBO(71, 161, 56, 1),
          textTheme: ButtonTextTheme.primary,
        ),
      ),
      home: Dashboard(),
    );
  }
}
