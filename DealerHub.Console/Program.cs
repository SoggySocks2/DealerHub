using DealerHub.Domain;

var dealer1 = new Dealer("ABC Motors", "Llandudno", "01492 123456");
var dealer2 = new Dealer("XYZ Motors", "Deganwy", "01492 654321");


List<Customer> customer = new List<Customer>();
var customer1 = new Customer("Alan", "Davis", 52, "Penrhyn Bay", "Conwy", "United Kingdom","LL31 8TA", "87938 173827", "01492 827388", "alandavis@gmail.com");
var customer2 = new Customer("Jessica", "Thomas", 46, "Conwy", "Conwy", "United Kingdom", "LL31 6YA", "837263 827462", "01492 193823", "jessthombis@hotmail.co.uk");
customer.Add(customer1);
customer.Add(customer2);

Console.WriteLine($"Dealer 1: {dealer1.Name} - {dealer1.Address} - {dealer1.Telephone}");
Console.WriteLine($"Dealer 2: {dealer2.Name} - {dealer2.Address} - {dealer2.Telephone}");
Console.WriteLine();

for( int i = 0; i < customer.Count; i++ )
{
    var elem = customer[i]; 

    Console.WriteLine($"Customer {i+1}: {elem.FirstName} {elem.LastName} ({elem.Age})");
    Console.WriteLine($"{elem.AddressLine1}, {elem.AddressLine2}, {elem.AddressLine3}, {elem.PostCode}");
    Console.WriteLine($"Home Tel: {elem.HomeTelNo}");
    Console.WriteLine($"Mobile Tel: {elem.MobileTelNo}");
    Console.WriteLine($"Email: {elem.EmailAddress}");
    Console.WriteLine();
}

Console.ReadLine();
