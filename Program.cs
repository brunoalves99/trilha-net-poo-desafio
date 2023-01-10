using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("97653322", "Modelo 1", "223", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("88223344", "Modelo 2", "332", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");