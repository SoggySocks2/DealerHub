namespace DealerHub.Domain;
public class Customer
{
    public Person Person { get; private set; } = default!;
    public Address Address { get; private set; } = default!;
    public ContactInfo ContactInfo { get; private set; } = default!;

    private Customer() { } /* Required by Entity Framework */
    public Customer(Person person, Address address, ContactInfo contactInfo)
    {
        UpdatePerson(person);
        UpdateAddress(address);
        UpdateContactInfo(contactInfo);
    }
    public void UpdatePerson(Person newPerson)
    {
        ArgumentNullException.ThrowIfNull(newPerson);
        Person = newPerson;
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
