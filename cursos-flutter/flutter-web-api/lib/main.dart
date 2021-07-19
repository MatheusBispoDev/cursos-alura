import 'package:flutter/material.dart';
import 'package:flutterwebapi/screens/dashboard.dart';

//const _urlimagem = 'https://scontent.fcgh2-1.fna.fbcdn.net/v/t1.6435-9/134922319_1573446086187874_2173135591167973273_n.jpg?_nc_cat=110&ccb=1-3&_nc_sid=09cbfe&_nc_eui2=AeFEel2RyK5Bbbe7JBg1EtKhYshJ-ebx1bBiyEn55vHVsJfSHCc_bsi-j6ZZmiaUIFTyZeyj9_HOEDHShaO1Fz5j&_nc_ohc=DHAiHBxqKukAX-wLSG_&_nc_oc=AQl3DtHlZF_ONKzY1R0wT2lp3bS5eeejWu1DZo1_jSCeF7kk0_41z_sK8zk5-qg6H7fcibTgG41NarmgSGhc5DW1&_nc_ht=scontent.fcgh2-1.fna&oh=09a4a2010dd11bc547cd6e3281aa2555&oe=60D9857C';

void main() {
  runApp(BytebankApp());
}

class BytebankApp extends StatelessWidget {
  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        theme: ThemeData(
          primaryColor: Colors.green[900],
          accentColor: Colors.blueAccent[700],
          buttonTheme: ButtonThemeData(
            buttonColor: Colors.blueAccent[700],
            textTheme: ButtonTextTheme.primary,
          ),
        ),
        debugShowCheckedModeBanner: false,
        home: Dashboard());
  }
}
