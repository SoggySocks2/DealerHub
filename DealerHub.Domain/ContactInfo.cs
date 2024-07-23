namespace DealerHub.Domain;

public class ContactInfo
{    
    public string HomeTelNo { get; private set; } = string.Empty;
    public string MobileTelNo { get; private set; } = string.Empty;
    public string EmailAddress { get; private set; } = string.Empty;

    public ContactInfo(string homeTelNo, string mobileTelNo, string emailAddress)
    {
        HomeTelNo = homeTelNo;
        MobileTelNo = mobileTelNo;
        EmailAddress = emailAddress;
    }
}
