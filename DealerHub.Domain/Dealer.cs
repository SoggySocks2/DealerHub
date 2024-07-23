namespace DealerHub.Domain;
public class Dealer
{
    public string Name { get; private set; } = string.Empty;
    public Address Address;
    public ContactInfo ContactInfo;
    public Dealer(string name, Address address, ContactInfo contactInfo)
    {
        UpdateName(name);
        UpdateAddress(address);
        UpdateContactInfo(contactInfo);


    }
    private void UpdateName(string newName)
    {
        ArgumentNullException.ThrowIfNull(newName);
        Name = newName;
    }
    private void UpdateAddress(Address newAddress)
    {
        ArgumentNullException.ThrowIfNull(newAddress);
        Address = newAddress;
    }

    private void UpdateContactInfo(ContactInfo newContactInfo)
    {
        ArgumentNullException.ThrowIfNull(newContactInfo);
        ContactInfo = newContactInfo;
    }

}