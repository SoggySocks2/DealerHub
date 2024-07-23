using DealerHub.Domain;

namespace DealerHub.Console;
public class Controller
{
    public async Task ProcessCustomers()
    {
        var dealer1 = new Dealer("ABC Motors", "Llandudno", "LL33 1BC", "01492 123456");
        var dealer2 = new Dealer("XYZ Motors", "Deganwy", "LL51 8PW", "01492 654321");


        List<Customer> customer = new List<Customer>();
        var customer1 = new Customer("Alan", "Davis", 52, "Penrhyn Bay", "Conwy", "United Kingdom", "LL31 8TA", "87938 173827", "01492 827388", "alandavis@gmail.com");
        var customer2 = new Customer("Jessica", "Thomas", 46, "Conwy", "Conwy", "United Kingdom", "LL31 6YA", "837263 827462", "01492 193823", "jessthombis@hotmail.co.uk");
        customer.Add(customer1);
        customer.Add(customer2);

        System.Console.WriteLine($"Dealer 1: {dealer1.Name} - {dealer1.Address} - {dealer1.PostCode} - {dealer1.Telephone}");
        System.Console.WriteLine($"Dealer 2: {dealer2.Name} - {dealer2.Address} - {dealer2.PostCode} - {dealer2.Telephone}");
        System.Console.WriteLine();

        for (int i = 0; i < customer.Count; i++)
        {
            var elem = customer[i];

            System.Console.WriteLine($"Customer {i + 1}: {elem.FirstName} {elem.LastName} ({elem.Age})");
            System.Console.WriteLine($"{elem.AddressLine1}, {elem.AddressLine2}, {elem.AddressLine3}, {elem.PostCode}");
            System.Console.WriteLine($"Home Tel: {elem.HomeTelNo}");
            System.Console.WriteLine($"Mobile Tel: {elem.MobileTelNo}");
            System.Console.WriteLine($"Email: {elem.EmailAddress}");
            System.Console.WriteLine();
        }

        System.Console.ReadLine();
    }
}
