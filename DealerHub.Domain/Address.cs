namespace DealerHub.Domain;
public class Address
{
    public string AddressLine1 { get; private set; } = string.Empty;
    public string AddressLine2 { get; private set; } = string.Empty;
    public string AddressLine3 { get; private set; } = string.Empty;
    public string PostCode { get; private set; } = string.Empty;


    public Address(string addressLine1, string addressLine2, string addressLine3, string postCode)
    {
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        AddressLine3 = addressLine3;
        PostCode = postCode;
    }
}