import 'package:flutterwebapi/http/interceptors/logging.dart';
import 'package:http/http.dart';
import 'package:http_interceptor/http_interceptor.dart';

final Client client =
    InterceptedClient.build(interceptors: [LoggingInterceptor()],
    requestTimeout: Duration(seconds: 5));

const String baseUrl = 'http://3b8191fad648.ngrok.io/transactions';