using DealerHub.Domain;

namespace DealerHub.Shared.Tests.Shared;
public record PersonBuilder
{
    public string FirstName { get; set; } = "Test First Name";
    public string LastName { get; set; } = "Test Last Name";
    public int Age { get; private set; } = 30;

    public Person Build()
    {
        return new Person(FirstName, LastName, new DateTime(DateTime.Now.Year - Age, 1, 1));
    }
}
