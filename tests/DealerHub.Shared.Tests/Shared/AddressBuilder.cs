using DealerHub.Domain;

namespace DealerHub.Shared.Tests.Shared;
public record AddressBuilder
{
    public string AddressLine1 { get; set; } = "Test AddressLine1";
    public string AddressLine2 { get; set; } = "Test AddressLine2";
    public string AddressLine3 { get; set; } = "Test AddressLine3";
    public string PostCode { get; set; } = "Test PostCode";

    public Address Build()
    {
        return new Address(AddressLine1, AddressLine2, AddressLine3, PostCode);
    }
}
