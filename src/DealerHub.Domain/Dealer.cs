namespace DealerHub.Domain;

public class Dealer
{
    public Guid Id { get; private set; } = Guid.Empty;
    public string Name { get; private set; } = string.Empty;
    public Address Address { get; private set; } = default!;
    public ContactInfo ContactInfo { get; private set; } = default!;

    private Dealer() { } /* Required by Entity Framework */
    public Dealer(string name, Address address, ContactInfo contactInfo)
    {
        UpdateName(name);
        UpdateAddress(address);
        UpdateContactInfo(contactInfo);
    }
    public void UpdateName(string newName)
    {
        ArgumentNullException.ThrowIfNull(newName);
        Name = newName;
    }
    public void UpdateAddress(Address newAddress)
    {
        ArgumentNullException.ThrowIfNull(newAddress);
        Address = newAddress;
    }
    public void UpdateContactInfo(ContactInfo newContactInfo)
    {
        ArgumentNullException.ThrowIfNull(newContactInfo);
        ContactInfo = newContactInfo;
    }
}