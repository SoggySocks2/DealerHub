﻿using DealerHub.Domain;

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
var person1 = new Person("Alan", "Davis", 52);
var person1_address = new Address("Penrhyn Bay", "Conwy", "United Kingdom", "LL31 8TA");
var person1_contactInfo = new ContactInfo("87938 173827", "01492 827388", "alandavis@gmail.com");
var customer1 = new Customer(person1, person1_address, person1_contactInfo);
customer.Add(customer1);

var person2 = new Person("Jessica", "Thomas", 46);
var person2_address = new Address("Conwy", "Conwy", "United Kingdom", "LL31 6YA");
var person2_contactInfo = new ContactInfo("837263 827462", "01492 193823", "jessthombis@hotmail.co.uk");
var customer2 = new Customer(person2, person2_address, person2_contactInfo);
customer.Add(customer2);


for (int i = 0; i < customer.Count; i++)
{
    var elem = dealer[i];

    Console.WriteLine($"Dealer {i + 1}: ");
    Console.WriteLine($"{elem.Name}");
    Console.WriteLine($"{elem.Address.AddressLine1}, {elem.Address.AddressLine2}, {elem.Address.AddressLine3} - {elem.Address.PostCode}");
    Console.WriteLine($"Tel: {elem.ContactInfo.HomeTelNo}");
    Console.WriteLine($"Email: {elem.ContactInfo.EmailAddress}"); 
    Console.WriteLine();
}

Console.WriteLine("\r\n \r\n"); //spacing

for (int i = 0; i < customer.Count; i++)
{
    var elem = customer[i];

    Console.WriteLine($"Customer {i + 1}: ");
    Console.WriteLine($"{elem.Person.FirstName} {elem.Person.LastName} ({elem.Person.Age})");
    Console.WriteLine($"{elem.Address.AddressLine1}, {elem.Address.AddressLine2}, {elem.Address.AddressLine3}, {elem.Address.PostCode}");
    Console.WriteLine($"Home Tel: {elem.ContactInfo.HomeTelNo}");
    Console.WriteLine($"Mobile Tel: {elem.ContactInfo.MobileTelNo}");
    Console.WriteLine($"Email: {elem.ContactInfo.EmailAddress}");
    Console.WriteLine();
}

Console.ReadLine();
