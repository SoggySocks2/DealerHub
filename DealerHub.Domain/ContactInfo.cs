namespace DealerHub.Domain;

public class ContactInfo
{
    public string HomeTelNo { get; private set; } = string.Empty;
    public string MobileTelNo { get; private set; } = string.Empty;
    public string EmailAddress { get; private set; } = string.Empty;

    private ContactInfo() { } /* Required by Entity Framework */
    public ContactInfo(string homeTelNo, string mobileTelNo, string emailAddress)
    {
        UpdateHomeTelNo(homeTelNo);
        UpdateMobileTelNo(mobileTelNo);
        UpdateEmailAddress(emailAddress);
    }
    public void UpdateHomeTelNo(string newHomeTelNo)
    {
        ArgumentNullException.ThrowIfNull(newHomeTelNo);
        HomeTelNo = newHomeTelNo;
    }
    public void UpdateMobileTelNo(string newMobileTelNo)
    {
        ArgumentNullException.ThrowIfNull(newMobileTelNo);
        MobileTelNo = newMobileTelNo;
    }
    public void UpdateEmailAddress(string newEmailAddress)
    {
        ArgumentNullException.ThrowIfNull(newEmailAddress);
        EmailAddress = newEmailAddress;
    }
}
