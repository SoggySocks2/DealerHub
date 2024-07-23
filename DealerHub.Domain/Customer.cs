namespace DealerHub.Domain;
public class Customer
{
    public Person Person;
    public Address Address;
    public ContactInfo ContactInfo;


    public Customer(Person person, Address address, ContactInfo contactInfo)
    {
        UpdatePerson(person);
        UpdateAddress(address);
        UpdateContactInfo(contactInfo);
    }
    private void UpdatePerson(Person newPerson)
    {
        ArgumentNullException.ThrowIfNull(newPerson);
        Person = newPerson;
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
