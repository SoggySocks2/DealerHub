using DealerHub.Domain;

var dealer1 = new Dealer("ABC Motors", "Llandudno", "01492 123456");
var dealer2 = new Dealer("XYZ Motors", "Deganwy", "01492 654321");

Console.WriteLine($"Dealer 1: {dealer1.Name} - {dealer1.Address} - {dealer1.Telephone}");
Console.WriteLine($"Dealer 2: {dealer2.Name} - {dealer2.Address} - {dealer2.Telephone}");

Console.ReadLine();
