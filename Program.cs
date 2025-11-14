using DesafioPOO.Models;

Console.WriteLine("NOKIA: ");
Smartphone nokia = new Nokia(numero: "+55 11 10001001", imei: "1111111", modelo: "Modelo 1", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("IPHONE: ");
Smartphone iphone = new Iphone(numero: "+55 11 30003003", imei: "2222222", modelo: "Modelo 1", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");