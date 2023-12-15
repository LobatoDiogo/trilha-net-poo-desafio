using DesafioPOO.Models;


Smartphone nokia = new Nokia("123456789", "Nokia 3310", "aaaaaa", 16);
Smartphone iphone = new Iphone("987654321", "Iphone 14", "bbbbbb", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Linkedin");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
