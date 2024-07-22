using DealerHub.Domain;

var dealer1 = new Dealer("ABC Motors", "Llandudno", "01492 123456");
var dealer2 = new Dealer("XYZ Motors", "Deganwy", "01492 654321");

var customer1 = new Customer("Alan", "Davis", "Penrhyn Bay", "01492 827388");
var customer2 = new Customer("Jessica", "Thomas", "Conwy", "01492 193823");

Console.WriteLine($"Dealer 1: {dealer1.Name} - {dealer1.Address} - {dealer1.Telephone}");
Console.WriteLine($"Dealer 2: {dealer2.Name} - {dealer2.Address} - {dealer2.Telephone}");
Console.WriteLine("\r\n");

Console.WriteLine($"Customer 1: {customer1.FirstName} {customer1.LastName} - {customer1.Address} - {customer1.Telephone}");
Console.WriteLine($"Customer 2: {customer2.FirstName} {customer2.LastName} - {customer2.Address} - {customer2.Telephone}");


Console.ReadLine();
