namespace DealerHub.Domain;
public class Dealer
{
    public string Name { get; private set; } = string.Empty;
    public string Address { get; private set; } = string.Empty;
    public string PostCode { get; private set; } = string.Empty;
    public string Telephone { get; private set; } = string.Empty;

    public Dealer(string name, string address, string postCode, string telephone)
    {
        UpdateName(name);
        UpdateAddress(address);
        UpdatePostCode(postCode);
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
    private void UpdatePostCode(string newPostCode)
    {
        ArgumentNullException.ThrowIfNull(newPostCode);
        PostCode = newPostCode;
    }
    private void UpdateTelephone(string newTelephone)
    {
        ArgumentNullException.ThrowIfNull(newTelephone);
        Telephone = newTelephone;
    }
}