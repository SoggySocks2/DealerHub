using DealerHub.Console;
using DealerHub.Console.Setup;
using DealerHub.Infrastructure.Setup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


List<Dealer> dealer = new List<Dealer>();
var dealer1_address = new Address("Llandudno", "Conwy", "United Kingdom", "LL33 1BC");
var dealer1_contactInfo = new ContactInfo("01492 123456", "", "management@ABCM.co.uk");
var dealer1 = new Dealer("ABC Motors", dealer1_address, dealer1_contactInfo);
dealer.Add(dealer1);

List<Customer> customer = new List<Customer>();
var customer1 = new Customer("Alan", "Davis", 52, "Penrhyn Bay", "Conwy", "United Kingdom", "LL31 8TA", "87938 173827", "01492 827388", "alandavis@gmail.com");
var customer2 = new Customer("Jessica", "Thomas", 46, "Conwy", "Conwy", "United Kingdom", "LL31 6YA", "837263 827462", "01492 193823", "jessthombis@hotmail.co.uk");
customer.Add(customer1);
customer.Add(customer2);

Console.WriteLine($"Dealer 1: {dealer1.Name} - {dealer1.Address} - {dealer1.PostCode} - {dealer1.Telephone}");
Console.WriteLine($"Dealer 2: {dealer2.Name} - {dealer2.Address} - {dealer2.PostCode} - {dealer2.Telephone}");
Console.WriteLine();

static IHostBuilder CreateHostBuilder(string[] args)
{
    var builder = new ConfigurationBuilder()
        .SetBasePath(Path.Combine(AppContext.BaseDirectory))
        .AddJsonFile("appsettings.json", optional: false)
        .AddJsonFile($"appsettings.Development.json", optional: true, reloadOnChange: true);

    var configuration = builder.Build();

    configuration.BindConfigurations();

    Console.WriteLine($"Customer {i + 1}: {elem.FirstName} {elem.LastName} ({elem.Age})");
    Console.WriteLine($"{elem.AddressLine1}, {elem.AddressLine2}, {elem.AddressLine3}, {elem.PostCode}");
    Console.WriteLine($"Home Tel: {elem.HomeTelNo}");
    Console.WriteLine($"Mobile Tel: {elem.MobileTelNo}");
    Console.WriteLine($"Email: {elem.EmailAddress}");
    Console.WriteLine();
}

Console.ReadLine();
