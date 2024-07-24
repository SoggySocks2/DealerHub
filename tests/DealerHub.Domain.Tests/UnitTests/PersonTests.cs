using FluentAssertions;

namespace DealerHub.Domain.Tests.UnitTests;
public class PersonTests
{
    [Fact]
    public void UpdateFirstName_WhenValid_SetsName()
    {
        //Arrange
        var originalFirstName = "Ben";
        var newFirstName = "Benjamin";
        var lastName = "Jones";
        var dateOfBirth = new DateTime(1999, 02, 03);

        var person = new Person(originalFirstName, lastName, dateOfBirth);
        person.UpdateFirstName(newFirstName);

        person.FirstName.Should().Be(newFirstName);
    }
    [Fact]
    public void UpdateLastName_WhenValid_SetsName()
    {
        var firstName = "Benjamin";
        var originalLastName = "Smith";
        var newLastName = "Jones";
        var dateOfBirth = new DateTime(1999, 02, 03);

        var person = new Person(firstName, originalLastName, dateOfBirth);
        person.UpdateLastName(newLastName);

        person.LastName.Should().Be(newLastName);
    }
    [Fact]
    public void UpdateAge_WhenValid_SetsName()
    {
        var firstName = "Benjamin";
        var lastName = "Jones";

        var originalDateOfBirth = new DateTime(1999, 02, 03);
        var originalAge = DateTime.Today.Year - originalDateOfBirth.Year;

        var newDateOfBirth = new DateTime(2001, 04, 01);
        var newAge = DateTime.Today.Year - newDateOfBirth.Year;

        var person = new Person(firstName, lastName, originalDateOfBirth);
        person.UpdateAge(newDateOfBirth);

        person.Age.Should().Be(newAge);
    }
    [Fact]
    public void Constructor_WhenFirstNameIsNull_Throws()
    {
        //Arrange
        var dateOfBirth = new DateTime(1999, 02, 03);
        var lastName = "Jones";

        //Act
        var act = () => new Person(null!, lastName, dateOfBirth);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }
    [Fact]
    public void Constructor_WhenLastNameIsNull_Throws()
    {
        //Arrange
        var dateOfBirth = new DateTime(1999, 02, 03);
        var firstName = "Benjamin";

        //Act
        var act = () => new Person(firstName, null!, dateOfBirth);

        //Assert
        act.Should().Throw<ArgumentNullException>();
    }

}
