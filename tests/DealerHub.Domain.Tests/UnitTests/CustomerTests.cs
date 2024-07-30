using DealerHub.Shared.Tests.Customers;
using DealerHub.Shared.Tests.Dealers;
using DealerHub.Shared.Tests.Shared;
using FluentAssertions;
using FluentAssertions.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerHub.Domain.Tests.UnitTests;
public class CustomerTests
{
    [Fact]
    public void UpdatePerson_WhenValid_SetsPerson()
    {
        //Arrange
        var customer = new CustomerBuilder().Build();

        //Act
        var newPerson = new Person("Benjamin", "Jones", new DateTime(1999, 5, 19));
        customer.UpdatePerson(newPerson);

        //Assert
        customer.Person.FirstName.Should().Be(newPerson.FirstName);
        customer.Person.LastName.Should().Be(newPerson.LastName);
        customer.Person.Age.Should().Be(newPerson.Age);


    }
    [Fact]
    public void UpdateAddress_WhenValid_SetsAddress()
    {
        //Arrange
        var customer = new CustomerBuilder().Build();

        //Act
        var newAddress = new Address("16 Pentywyn Heights", "Deganwy", "Conwy", "LL31 9DT");
        customer.UpdateAddress(newAddress);

        //Assert
        customer.Address.AddressLine1.Should().Be(newAddress.AddressLine1);
        customer.Address.AddressLine2.Should().Be(newAddress.AddressLine2);
        customer.Address.AddressLine3.Should().Be(newAddress.AddressLine3);
        customer.Address.PostCode.Should().Be(newAddress.PostCode);


    }
    [Fact]
    public void UpdateContactInfo_WhenValid_SetsContactInfo()
    {
        //Arrange
        var customer = new CustomerBuilder().Build();

        //Act
        var newContactInfo = new ContactInfo("827425 892783", "01726 827738", "benjaminjones@gmail.com");
        customer.UpdateContactInfo(newContactInfo);

        //Assert
        customer.ContactInfo.HomeTelNo.Should().Be(newContactInfo.HomeTelNo);
        customer.ContactInfo.MobileTelNo.Should().Be(newContactInfo.MobileTelNo);
        customer.ContactInfo.EmailAddress.Should().Be(newContactInfo.EmailAddress);

    }
    [Fact]
    public void Constructor_WhenPersonIsProvided_SetsPerson()
    {
        //Arrange
        Person person = new Person("Benjamin", "Jones", new DateTime(1999, 5, 19));

        //Act
        var customer = new CustomerBuilder() { Person = person }.Build();

        //Assert
        customer.Person.FirstName.Should().Be(person.FirstName);
        customer.Person.LastName.Should().Be(person.LastName);
        customer.Person.Age.Should().Be(person.Age);

    }
    [Fact]
    public void Constructor_WhenAddressIsProvided_SetsAddress()
    {
        //Arrange
        Address address = new Address("16 Pentywyn Heights", "Deganwy", "Conwy", "LL31 9DT");

        //Act
        var customer = new CustomerBuilder() { Address = address }.Build();

        //Assert
        customer.Address.AddressLine1.Should().Be(address.AddressLine1);
        customer.Address.AddressLine2.Should().Be(address.AddressLine2);
        customer.Address.AddressLine3.Should().Be(address.AddressLine3);
        customer.Address.PostCode.Should().Be(address.PostCode);


    }
    [Fact]
    public void Constructor_WhenContactInfoIsProvided_SetsContactInfo()
    {
        //Arrange
        var contactInfo = new ContactInfo("827425 892783", "01726 827738", "benjaminjones@gmail.com");

        //Act
        var customer = new CustomerBuilder() { ContactInfo = contactInfo }.Build();

        //Assert
        customer.ContactInfo.HomeTelNo.Should().Be(contactInfo.HomeTelNo);
        customer.ContactInfo.MobileTelNo.Should().Be(contactInfo.MobileTelNo);
        customer.ContactInfo.EmailAddress.Should().Be(contactInfo.EmailAddress);


    }
    [Fact]
    public void Constructor_WhenPersonIsNull_Throws()
    {
        //Arrange
        var address = new AddressBuilder().Build();
        var contactInfo = new ContactInfoBuilder().Build();

        //Act
        var act = () => new Customer(null!, address, contactInfo);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
    [Fact]
    public void Constructor_WhenAddressIsNull_Throws()
    {
        //Arrange
        var name = new Person("Ben", "Jones", new DateTime(1999, 5, 19));
        var contactInfo = new ContactInfoBuilder().Build();

        //Act
        var act = () => new Customer(name, null!, contactInfo);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
    [Fact]
    public void Constructor_WhenContactInfoIsNull_Throws()
    {
        //Arrange
        var name = new Person("Ben", "Jones", new DateTime(1999, 5, 19));
        var address = new AddressBuilder().Build();

        //Act
        var act = () => new Customer(name, address, null!);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
}
