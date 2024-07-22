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
    public string Age { get; private set; } = string.Empty;
    public string AddressLine1 { get; private set; } = string.Empty;
    public string AddressLine2 { get; private set; } = string.Empty;
    public string AddressLine3 { get; private set; } = string.Empty;
    public string PostCode { get; private set; } = string.Empty;
    public string HomeTelNo { get; private set; } = string.Empty;
    public string MobileTelNo { get; private set; } = string.Empty;
    public string EmailAddress { get; private set; } = string.Empty;


    public Customer(string firstname, string lastname, string age, string addressline1, string addressline2, string addressline3, string postcode, string hometelno, string mobiletelno, string emailaddress)
    {
        UpdateName(firstname, lastname);
        UpdateAge(age);
        UpdateAddress(addressline1, addressline2, addressline3);
        UpdateContact(hometelno, mobiletelno, emailaddress);
    }

    private void UpdateName(String newFirstName, String newLastName)
    {
        ArgumentNullException.ThrowIfNull(newFirstName);
        ArgumentNullException.ThrowIfNull(newLastName);
        FirstName = newFirstName;
        LastName = newLastName;
    }
    private void UpdateAge(String newAge)
    {
        ArgumentNullException.ThrowIfNull(newAge);
        Age = newAge;
    }
    private void UpdateAddress(String newAddressLine1, String newAddressLine2, String newAddressLine3)
    {
        ArgumentNullException.ThrowIfNull(newAddressLine1);
        ArgumentNullException.ThrowIfNull(newAddressLine2);
        ArgumentNullException.ThrowIfNull(newAddressLine3);
        AddressLine1 = newAddressLine1;
        AddressLine2 = newAddressLine2;
        AddressLine3 = newAddressLine3;
    }
    private void UpdateContact(String newHomeTelNo, String newMobileTelNo, String newEmailAddress)
    {
        ArgumentNullException.ThrowIfNull(newHomeTelNo);
        ArgumentNullException.ThrowIfNull(newMobileTelNo);
        ArgumentNullException.ThrowIfNull(newEmailAddress);
        HomeTelNo = newHomeTelNo;
        MobileTelNo = newMobileTelNo;
        EmailAddress = newEmailAddress;
    }
}
