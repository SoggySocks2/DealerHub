using DealerHub.Domain;

namespace DealerHub.Shared.Tests.Shared;
public record ContactInfoBuilder
{
    public string HomeTelNo { get; set; } = "01492 123456";
    public string MobileTelNo { get; set; } = "07920 789012";
    public string EmailAddress { get; set; } = "test.email@test.com";

    public ContactInfo Build()
    {
        return new ContactInfo(HomeTelNo, MobileTelNo, EmailAddress);
    }
}
