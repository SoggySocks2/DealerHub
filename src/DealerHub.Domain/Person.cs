namespace DealerHub.Domain;
public class Person
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public int Age { get; private set; } = 0;

    private Person() { } /* Required by Entity Framework */
    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        UpdateFirstName(firstName);
        UpdateLastName(lastName);
        UpdateAge(dateOfBirth);
    }
    public void UpdateFirstName(string newFirstName)
    {
        ArgumentNullException.ThrowIfNull(newFirstName);
        FirstName = newFirstName;
    }
    public void UpdateLastName(string newLastName)
    {
        ArgumentNullException.ThrowIfNull(newLastName);
        LastName = newLastName;
    }
    public void UpdateAge(DateTime newDOBYear)
    {
        Age = DateTime.Today.Year - newDOBYear.Year;
    }
}