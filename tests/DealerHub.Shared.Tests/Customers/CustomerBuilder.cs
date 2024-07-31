using DealerHub.Domain;
using DealerHub.Shared.Tests.Shared;


namespace DealerHub.Shared.Tests.Customers;
public record CustomerBuilder
{
    public Person Person { get; set; } = new PersonBuilder().Build();
    public Address Address { get; set; } = new AddressBuilder().Build();
    public ContactInfo ContactInfo { get; set; } = new ContactInfoBuilder().Build();

    public Customer Build()
    {
        return new Customer(Person, Address, ContactInfo);
    }
}
