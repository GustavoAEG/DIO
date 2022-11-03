using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Android Nokia");
Nokia android = new Nokia(numero: "12345677",modelo:"Nokia GT-30",imei:"SDASD223ESDA", memoria:512);

android.Ligar();
android.ReceberLigacao();
android.InstalarAplicativo("Employer App");
