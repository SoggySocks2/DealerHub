using DealerHub.Domain;

namespace DealerHub.Shared.Tests.Shared;
public record PersonBuilder
{
    public string FirstName { get; set; } = "Test First Name";
    public string LastName { get; set; } = "Test Last Name";

    public DateTime DateOfBirth { get; set; } = new DateTime(2000,1,1);

    public Person Build()
    {
        return new Person(FirstName, LastName, DateOfBirth);
    }
}
