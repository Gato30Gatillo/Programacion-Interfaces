// File generated by FlutterFire CLI.
// ignore_for_file: type=lint
import 'package:firebase_core/firebase_core.dart' show FirebaseOptions;
import 'package:flutter/foundation.dart'
    show defaultTargetPlatform, kIsWeb, TargetPlatform;

/// Default [FirebaseOptions] for use with your Firebase apps.
///
/// Example:
/// ```dart
/// import 'firebase_options.dart';
/// // ...
/// await Firebase.initializeApp(
///   options: DefaultFirebaseOptions.currentPlatform,
/// );
/// ```
class DefaultFirebaseOptions {
  static FirebaseOptions get currentPlatform {
    if (kIsWeb) {
      return web;
    }
    switch (defaultTargetPlatform) {
      case TargetPlatform.android:
        return android;
      case TargetPlatform.iOS:
        return ios;
      case TargetPlatform.macOS:
        return macos;
      case TargetPlatform.windows:
        return windows;
      case TargetPlatform.linux:
        throw UnsupportedError(
          'DefaultFirebaseOptions have not been configured for linux - '
          'you can reconfigure this by running the FlutterFire CLI again.',
        );
      default:
        throw UnsupportedError(
          'DefaultFirebaseOptions are not supported for this platform.',
        );
    }
  }

  static const FirebaseOptions web = FirebaseOptions(
    apiKey: 'AIzaSyD0UWexElNSHUi9y9X96fLHHMMfK-xxSn4',
    appId: '1:963684907742:web:81cb833c1e5d6f03ede04f',
    messagingSenderId: '963684907742',
    projectId: 'nuevo-proyecto-62b0f',
    authDomain: 'nuevo-proyecto-62b0f.firebaseapp.com',
    storageBucket: 'nuevo-proyecto-62b0f.firebasestorage.app',
  );

  static const FirebaseOptions android = FirebaseOptions(
    apiKey: 'AIzaSyCnCHohVDtQVZA3CPSnr-1lbJcLt5qXOwc',
    appId: '1:963684907742:android:b05b4c96817e57f8ede04f',
    messagingSenderId: '963684907742',
    projectId: 'nuevo-proyecto-62b0f',
    storageBucket: 'nuevo-proyecto-62b0f.firebasestorage.app',
  );

  static const FirebaseOptions ios = FirebaseOptions(
    apiKey: 'AIzaSyANyEER-k507eizfWm7ZhxRc-ORA7FhFTw',
    appId: '1:963684907742:ios:5ac29089c5055ac2ede04f',
    messagingSenderId: '963684907742',
    projectId: 'nuevo-proyecto-62b0f',
    storageBucket: 'nuevo-proyecto-62b0f.firebasestorage.app',
    iosClientId: '963684907742-s8arugep35q8c37o556pb9cuqq1dc2ka.apps.googleusercontent.com',
    iosBundleId: 'com.example.iseneca',
  );

  static const FirebaseOptions macos = FirebaseOptions(
    apiKey: 'AIzaSyANyEER-k507eizfWm7ZhxRc-ORA7FhFTw',
    appId: '1:963684907742:ios:5ac29089c5055ac2ede04f',
    messagingSenderId: '963684907742',
    projectId: 'nuevo-proyecto-62b0f',
    storageBucket: 'nuevo-proyecto-62b0f.firebasestorage.app',
    iosClientId: '963684907742-s8arugep35q8c37o556pb9cuqq1dc2ka.apps.googleusercontent.com',
    iosBundleId: 'com.example.iseneca',
  );

  static const FirebaseOptions windows = FirebaseOptions(
    apiKey: 'AIzaSyD0UWexElNSHUi9y9X96fLHHMMfK-xxSn4',
    appId: '1:963684907742:web:bd04bfd704fc3fdbede04f',
    messagingSenderId: '963684907742',
    projectId: 'nuevo-proyecto-62b0f',
    authDomain: 'nuevo-proyecto-62b0f.firebaseapp.com',
    storageBucket: 'nuevo-proyecto-62b0f.firebasestorage.app',
  );
}