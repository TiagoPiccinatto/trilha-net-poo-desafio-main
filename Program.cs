using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
string IphoneSerie = "1257415";
string IphoneModelo = "Iphone";
string IphoneProtect = "19898443";
int IphoneMemoria = 2048;

Iphone iphone = new Iphone(IphoneSerie, IphoneModelo, IphoneProtect, IphoneMemoria);


iphone.InstalarAplicativo("IphoneApp");

string NokiaSerie = "555758";
string NokiaModelo = "Nokia";
string NokiaProtect = "74411615";
int NokiaMemoria = 1024;

Nokia Nokiaphone = new Nokia(NokiaSerie, NokiaModelo, NokiaProtect, NokiaMemoria);


Nokiaphone.InstalarAplicativo("NokiaApp");

