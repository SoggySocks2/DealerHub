namespace DealerHub.Domain;
public class Customer
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public int Age { get; private set; } = 0;
    public string AddressLine1 { get; private set; } = string.Empty;
    public string AddressLine2 { get; private set; } = string.Empty;
    public string AddressLine3 { get; private set; } = string.Empty;
    public string PostCode { get; private set; } = string.Empty;
    public string HomeTelNo { get; private set; } = string.Empty;
    public string MobileTelNo { get; private set; } = string.Empty;
    public string EmailAddress { get; private set; } = string.Empty;


    public Customer(string firstName, string lastName, int age, string addressLine1, string addressLine2, string addressLine3, string postCode, string homeTelNo, string mobileTelNo, string emailAddress)
    {
        UpdateName(firstName, lastName);
        UpdateAge(age);
        UpdateAddress(addressLine1, addressLine2, addressLine3);
        UpdateHomeTelNo(homeTelNo);
        UpdateMobileTelNo(mobileTelNo);
        UpdateEmailAddress(emailAddress);
    }

    private void UpdateName(string newFirstName, string newLastName)
    {
        ArgumentNullException.ThrowIfNull(newFirstName);
        ArgumentNullException.ThrowIfNull(newLastName);
        FirstName = newFirstName;
        LastName = newLastName;
    }
    private void UpdateAge(int newAge)
    {
        ArgumentNullException.ThrowIfNull(newAge);
        Age = newAge;
    }
    private void UpdateAddress(string newAddressLine1, string newAddressLine2, string newAddressLine3)
    {
        ArgumentNullException.ThrowIfNull(newAddressLine1);
        ArgumentNullException.ThrowIfNull(newAddressLine2);
        ArgumentNullException.ThrowIfNull(newAddressLine3);
        AddressLine1 = newAddressLine1;
        AddressLine2 = newAddressLine2;
        AddressLine3 = newAddressLine3;
    }
    private void UpdateHomeTelNo(string newHomeTelNo)
    {
        ArgumentNullException.ThrowIfNull(newHomeTelNo);
        HomeTelNo = newHomeTelNo;
    }
    private void UpdateMobileTelNo(string newMobileTelNo)
    {
        ArgumentNullException.ThrowIfNull(newMobileTelNo);
        MobileTelNo = newMobileTelNo;
    }
    private void UpdateEmailAddress(string newEmailAddress)
    {
        ArgumentNullException.ThrowIfNull(newEmailAddress);
        EmailAddress = newEmailAddress;
    }
}
