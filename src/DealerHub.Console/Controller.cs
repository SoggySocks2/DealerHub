using DealerHub.Console.Dealers;
using DealerHub.Domain;

namespace DealerHub.Console;
public class Controller
{
    private IDealerService _dealerService { get; set; }
    public Controller(IDealerService dealerService)
    {
        _dealerService = dealerService;
    }

    public async Task ProcessCustomers()
    {
        await SeedAndDisplayDealers();

        List<Dealer> dealer = new List<Dealer>();
        var dealer1_address = new Address("Llandudno", "Conwy", "United Kingdom", "LL33 1BC");
        var dealer1_contactInfo = new ContactInfo("01492 123456", "", "management@ABCM.co.uk");
        var dealer1 = new Dealer("ABC Motors", dealer1_address, dealer1_contactInfo);
        dealer.Add(dealer1);

        var dealer2_address = new Address("Deganwy", "Conwy", "United Kingdom", "LL51 8PW");
        var dealer2_contactInfo = new ContactInfo("01492 123456", "", "help@xyzmotors.com");
        var dealer2 = new Dealer("XYZ Motors", dealer2_address, dealer2_contactInfo);
        dealer.Add(dealer2);


        List<Customer> customer = new List<Customer>();
        var person1 = new Person("Alan", "Davis", new DateTime(1999, 02, 02));
        var person1_address = new Address("Penrhyn Bay", "Conwy", "United Kingdom", "LL31 8TA");
        var person1_contactInfo = new ContactInfo("87938 173827", "01492 827388", "alandavis@gmail.com");
        var customer1 = new Customer(person1, person1_address, person1_contactInfo);
        customer.Add(customer1);

        var person2 = new Person("Jessica", "Thomas", new DateTime(2015, 08, 18));
        var person2_address = new Address("Conwy", "Conwy", "United Kingdom", "LL31 6YA");
        var person2_contactInfo = new ContactInfo("837263 827462", "01492 193823", "jessthombis@hotmail.co.uk");
        var customer2 = new Customer(person2, person2_address, person2_contactInfo);
        customer.Add(customer2);

        var person3 = new Person("Billy", "Hopkins", new DateTime(1935, 06, 05));
        var person3_address = new Address("LLandudno", "Conwy", "United Kingdom", "LL30 8AA");
        var person3_contactInfo = new ContactInfo("846972 158586", "01492 958685", "billhops@hotmail.com");
        var customer3 = new Customer(person3, person3_address, person3_contactInfo);
        customer.Add(customer3);

        var person4 = new Person("Hank", "Tulips", new DateTime(1985, 11, 16));
        var person4_address = new Address("LLandudno", "Conwy", "United Kingdom", "LL30 8TZ");
        var person4_contactInfo = new ContactInfo("958465 845896", "01492 748596", "hank1923@gmail.com");
        var customer4 = new Customer(person4, person4_address, person4_contactInfo);
        customer.Add(customer4);

        for (int i = 0; i < dealer.Count; i++)
        {

            var elem = dealer[i];

            System.Console.WriteLine($"Dealer {i + 1}: ");
            System.Console.WriteLine($"{elem.Name}");
            System.Console.WriteLine($"{elem.Address.AddressLine1}, {elem.Address.AddressLine2}, {elem.Address.AddressLine3} - {elem.Address.PostCode}");
            System.Console.WriteLine($"Tel: {elem.ContactInfo.HomeTelNo}");
            System.Console.WriteLine($"Email: {elem.ContactInfo.EmailAddress}");
            System.Console.WriteLine();
        }



        System.Console.WriteLine("\r\n \r\n"); //spacing

        for (int i = 0; i < customer.Count; i++)
        {
            var elem = customer[i];

            if (elem.Person.Age >= 18 && elem.Person.Age <= 70)
            {
                System.Console.WriteLine($"Customer {i + 1}: ");
                System.Console.WriteLine($"{elem.Person.FirstName} {elem.Person.LastName} ({elem.Person.Age})");
                System.Console.WriteLine($"{elem.Address.AddressLine1}, {elem.Address.AddressLine2}, {elem.Address.AddressLine3}, {elem.Address.PostCode}");
                System.Console.WriteLine($"Home Tel: {elem.ContactInfo.HomeTelNo}");
                System.Console.WriteLine($"Mobile Tel: {elem.ContactInfo.MobileTelNo}");
                System.Console.WriteLine($"Email: {elem.ContactInfo.EmailAddress}");
                System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine($"    *****************************************");
                if (elem.Person.Age < 18)
                {
                    System.Console.WriteLine($"    Customer {i + 1} is underage!");
                }
                else
                {
                    System.Console.WriteLine($"    Customer {i + 1} is too old!");

                }
                System.Console.WriteLine($"    {elem.Person.FirstName} {elem.Person.LastName} ({elem.Person.Age} years old)");
                System.Console.WriteLine($"    *****************************************");
                System.Console.WriteLine();

            }
        }

        System.Console.ReadLine();
    }

    private async Task SeedAndDisplayDealers()
    {
        var dealers = await SeedDealers();
        DisplayDealers(dealers);
    }
    private async Task<List<Dealer>> SeedDealers()
    {
        var dealers = await _dealerService.GetListAsync(CancellationToken.None);

        if (dealers.Count > 0)
            return dealers;

        for (int i = 0; i < 5; i++)
        {
            var address = new Address($"Address Line 1 - {i}", $"Address Line 2 - {i}", $"Address Line 3 - {i}", $"LL3{i} ABC");
            var contactInfo = new ContactInfo($"Home Tel No - {i}", $"Mobile Tel No - {i}", $"email-{i}@test.com");
            var dealer = new Dealer($"Dealer {i}", address, contactInfo);
            await _dealerService.AddAsync(dealer, CancellationToken.None);
        }

        return await _dealerService.GetListAsync(CancellationToken.None);
    }
    private static void DisplayDealers(List<Dealer> dealers)
    {
        System.Console.WriteLine("==============================================================================");
        System.Console.WriteLine("==============================================================================");
        foreach (var dealer in dealers)
        {
            System.Console.WriteLine($"Dealer: {dealer.Name}");
            System.Console.WriteLine($"Address: {dealer.Address.AddressLine1}, {dealer.Address.AddressLine2}, {dealer.Address.AddressLine3} - {dealer.Address.PostCode}");
            System.Console.WriteLine($"Tel: {dealer.ContactInfo.HomeTelNo}");
            System.Console.WriteLine($"Email: {dealer.ContactInfo.EmailAddress}");
            System.Console.WriteLine();
        }
        System.Console.WriteLine("==============================================================================");
        System.Console.WriteLine("==============================================================================");
    }
}
