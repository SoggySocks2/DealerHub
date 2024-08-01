using DealerHub.Shared.Tests.Dealers;
using DealerHub.Shared.Tests.Shared;
using FluentAssertions;

namespace DealerHub.Domain.Tests.UnitTests;
public class DealerTests
{
    [Fact]
    public void UpdateName_WhenValid_SetsName()
    {
        //Arrange
        var dealer = new DealerBuilder().Build();

        //Act
        var newName = "Benjamin Jones";
        dealer.UpdateName(newName);

        //Assert
        dealer.Name.Should().Be(newName);
    }
    [Fact]
    public void UpdateAddress_WhenValid_SetsAddress()
    {
        //Arrange        
        var dealer = new DealerBuilder().Build();

        //Act
        var newAddress = new AddressBuilder() { AddressLine1 = "57 Caroline Road", AddressLine2 = "Southampton", AddressLine3 = "England", PostCode = "ST6 4WS" }.Build();
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
        var dealer = new DealerBuilder().Build();

        //Act
        var newContactInfo = new ContactInfo("08761 234521", "05721 765286", "test.user@test.com");
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

        //Act
        var dealer = new DealerBuilder() { Name = name }.Build();

        //Assert
        dealer.Name.Should().Be(name);
    }
    [Fact]
    public void Constructor_WhenNameIsNull_Throws()
    {
        //Arrange
        var address = new AddressBuilder().Build();
        var contactInfo = new ContactInfoBuilder().Build();

        //Act
        var act = () => new Dealer(default!, address, contactInfo);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
    [Fact]
    public void Constructor_WhenAddressIsNull_Throws()
    {
        //Arrange
        var name = "Ben Jones";
        var contactInfo = new ContactInfoBuilder().Build();

        //Act
        var act = () => new Dealer(name, default!, contactInfo);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
    [Fact]
    public void Constructor_WhenContactInfoIsNull_Throws()
    {
        //Arrange
        var name = "Ben Jones";
        var address = new AddressBuilder().Build();

        //Act
        var act = () => new Dealer(name, address, default!);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
}