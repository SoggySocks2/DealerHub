namespace DealerHub.Library;
public class Dealer
{
    public string Name { get; private set; } = string.Empty;
    public string Telephone { get; private set; } = string.Empty;

    public Dealer(string name, string telephone)
    {
        UpdateName(name);
        UpdateTelephone(telephone);
    }


    private void UpdateName(string newName)
    {
        ArgumentNullException.ThrowIfNull(newName);
        Name = newName;
    }

    private void UpdateTelephone(string newTelephone)
    {
        ArgumentNullException.ThrowIfNull(newTelephone);
        Telephone = newTelephone;
    }
}
