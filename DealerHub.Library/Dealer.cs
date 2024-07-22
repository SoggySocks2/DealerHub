namespace DealerHub.Library;
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
