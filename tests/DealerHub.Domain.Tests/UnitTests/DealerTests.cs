using FluentAssertions;

namespace DealerHub.Domain.Tests.UnitTests;
public class DealerTests
{
    [Fact]
    public void UpdateName_WhenValid_SetsName()
    {
        //Arrange
        var originalName = "Ben Jones";
        var newName = "Benjamin Jones";
        var address = new Address("84", "Driftwood Avenue", "Tadcaster", "TD1 9YS");
        var contactInfo = new ContactInfo("01234 567890", "07920 111222", "test@email.com");

        var dealer = new Dealer(originalName, address, contactInfo);
        dealer.UpdateName(newName);

        dealer.Name.Should().Be(newName);
    }
    [Fact]
    public void UpdateAddress_WhenValid_SetsAddress()
    {
        //Arrange
        var name = "Ben Jones";
        var originalAddress = new Address("84", "Driftwood Avenue", "Tadcaster", "TD1 9YS");
        var newAddress = new Address("57", "Caroline Road", "Southampton", "ST6 4WS");
        var contactInfo = new ContactInfo("01234 567890", "07920 111222", "test@email.com");

        //Act
        var dealer = new Dealer(name, originalAddress, contactInfo);
        dealer.UpdateAddress(newAddress);

        //Assert
        dealer.Address.AddressLine1.Should().Be(newAddress.AddressLine1);
        dealer.Address.AddressLine2.Should().Be(newAddress.AddressLine2);
        dealer.Address.AddressLine3.Should().Be(newAddress.AddressLine3);
        dealer.Address.PostCode.Should().Be(newAddress.PostCode);
    }
    [Fact]
    public void UpdateContactInfo_WhenValid_SetsContactInfo()
    {
        //Arrange
        var name = "Ben Jones";
        var address = new Address("84", "Driftwood Avenue", "Tadcaster", "TD1 9YS");
        var originalContactInfo = new ContactInfo("01234 567890", "07920 111222", "test@email.com");
        var newContactInfo = new ContactInfo("08761 234521", "05721 765286", "test.user@test.com");

        //Act
        var dealer = new Dealer(name, address, originalContactInfo);
        dealer.UpdateContactInfo(newContactInfo);

        //Assert
        dealer.ContactInfo.HomeTelNo.Should().Be(newContactInfo.HomeTelNo);
        dealer.ContactInfo.MobileTelNo.Should().Be(newContactInfo.MobileTelNo);
        dealer.ContactInfo.EmailAddress.Should().Be(newContactInfo.EmailAddress);
    }
    [Fact]
    public void Constructor_WhenNameIsProvided_SetsName()
    {
        //Arrange
        var name = "Ben Jones";
        var address = new Address("84", "Driftwood Avenue", "Tadcaster", "TD1 9YS");
        var contactInfo = new ContactInfo("01234 567890", "07920 111222", "test@email.com");

        //Act
        var dealer = new Dealer(name, address, contactInfo);

        //Assert
        dealer.Name.Should().Be(name);
    }
    [Fact]
    public void Constructor_WhenNameIsNull_Throws()
    {
        //Arrange
        var address = new Address("84", "Driftwood Avenue", "Tadcaster", "TD1 9YS");
        var contactInfo = new ContactInfo("01234 567890", "07920 111222", "test@email.com");

        //Act
        var act = () => new Dealer(null!, address, contactInfo);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
    [Fact]
    public void Constructor_WhenAddressIsNull_Throws()
    {
        //Arrange
        var name = "Ben Jones";
        var contactInfo = new ContactInfo("01234 567890", "07920 111222", "test@email.com");

        //Act
        var act = () => new Dealer(name, null!, contactInfo);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
    [Fact]
    public void Constructor_WhenContactInfoIsNull_Throws()
    {
        //Arrange
        var name = "Ben Jones";
        var address = new Address("84", "Driftwood Avenue", "Tadcaster", "TD1 9YS");

        //Act
        var act = () => new Dealer(name, address, null!);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
}