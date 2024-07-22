namespace DealerHub.Domain;
public class Dealer
{
    public string Name { get; private set; } = string.Empty;
    public string Address { get; private set; } = string.Empty;
    public string Telephone { get; private set; } = string.Empty;

    public Dealer(string name, string address, string telephone)
    {
        UpdateName(name);
        UpdateAddress(address);
        UpdateTelephone(telephone);
    }
    private void UpdateName(string newName)
    {
        ArgumentNullException.ThrowIfNull(newName);
        Name = newName;
    }
    private void UpdateAddress(string newAddress)
    {
        ArgumentNullException.ThrowIfNull(newAddress);
        Address = newAddress;
    }
    private void UpdateTelephone(string newTelephone)
    {
        ArgumentNullException.ThrowIfNull(newTelephone);
        Telephone = newTelephone;
    }
}

public class Customer
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string Address { get; private set; } = string.Empty;
    public string Telephone { get; private set; } = string.Empty;

    public Customer(string firstname, string lastname, string address, string telephone)
    {
        UpdateName(firstname, lastname);
        UpdateAddress(address);
        UpdateTelephone(telephone);
    }

    private void UpdateName(String newFirstName, String newLastName)
    {
        ArgumentNullException.ThrowIfNull(newFirstName);
        ArgumentNullException.ThrowIfNull(newLastName);
        FirstName = newFirstName;
        LastName = newLastName;
    }
    private void UpdateAddress(String newAddress)
    {
        ArgumentNullException.ThrowIfNull(newAddress);
        Address = newAddress;
    }
    private void UpdateTelephone(String newTelephone)
    {
        ArgumentNullException.ThrowIfNull(newTelephone);
        Telephone = newTelephone;
    }
}
