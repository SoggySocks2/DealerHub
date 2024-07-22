using DealerHub.Library;

var dealer1 = new Dealer("ABC Motors", "01492 123456");
var dealer2 = new Dealer("XYZ Motors", "01492 654321");

Console.WriteLine($"Dealer 1: {dealer1.Name} - {dealer1.Telephone}");
Console.WriteLine($"Dealer 2: {dealer2.Name} - {dealer2.Telephone}");

Console.ReadLine();
