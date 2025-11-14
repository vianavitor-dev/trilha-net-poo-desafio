using DesafioPOO.Models;
using Newtonsoft.Json;

Smartphone nokia = new Nokia(numero: "+55 11 10001001", imei: "1111111", modelo: "Modelo 1", memoria: 64);
Smartphone iphone = new Iphone(numero: "+55 11 30003003", imei: "2222222", modelo: "Modelo 1", memoria: 64);

Console.WriteLine("NOKIA: ");

/*
    Agora os celualres conseguem ligar um para o outro
    e atender
*/
nokia.Ligar(iphone);
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("");

Console.WriteLine("IPHONE: ");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");