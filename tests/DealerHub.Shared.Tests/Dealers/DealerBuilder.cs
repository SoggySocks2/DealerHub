using DealerHub.Domain;
using DealerHub.Shared.Tests.Shared;

namespace DealerHub.Shared.Tests.Dealers;

public record DealerBuilder
{
    public Guid Id { get; set; } = Guid.Empty;
    public string Name { get; set; } = string.Empty;
    public Address Address { get; set; } = new AddressBuilder().Build();
    public ContactInfo ContactInfo { get; set; } = new ContactInfoBuilder().Build();

    public Dealer Build()
    {
        return new Dealer(Name, Address, ContactInfo);
    }
}
