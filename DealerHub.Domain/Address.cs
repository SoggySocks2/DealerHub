namespace DealerHub.Domain;
public class Address
{
    public string AddressLine1 { get; private set; } = string.Empty;
    public string AddressLine2 { get; private set; } = string.Empty;
    public string AddressLine3 { get; private set; } = string.Empty;
    public string PostCode { get; private set; } = string.Empty;


    public Address(string addressLine1, string addressLine2, string addressLine3, string postCode)
    {
        UpdateAddressLine1(addressLine1);
        UpdateAddressLine2(addressLine2);
        UpdateAddressLine3(addressLine3);
        UpdatePostCode(postCode);
    }


    private void UpdateAddressLine1(string newAddressLine1)
    {
        ArgumentNullException.ThrowIfNull(newAddressLine1);
        AddressLine1 = newAddressLine1;
    }

    private void UpdateAddressLine2(string newAddressLine2)
    {
        ArgumentNullException.ThrowIfNull(newAddressLine2);
        AddressLine2 = newAddressLine2;
    }

    private void UpdateAddressLine3(string newAddressLine3)
    {
        ArgumentNullException.ThrowIfNull(newAddressLine3);
        AddressLine3 = newAddressLine3;
    }

    private void UpdatePostCode(string newPostCode)
    {
        ArgumentNullException.ThrowIfNull(newPostCode);
        PostCode = newPostCode;
    }
}