namespace DealerHub.Domain;
public class Person
{
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public int Age { get; private set; } = 0;
    

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        UpdateFirstName(firstName);
        UpdateLastName(lastName);
        UpdateAge(dateOfBirth);
    }

    private void UpdateFirstName(string newFirstName)
    {
        ArgumentNullException.ThrowIfNull(newFirstName);
        FirstName = newFirstName;
    }

    private void UpdateLastName(string newLastName)
    {
        ArgumentNullException.ThrowIfNull(newLastName);
        LastName = newLastName;
    }

    private void UpdateAge(DateTime newDOBYear)
    {
        Age = DateTime.Today.Year - newDOBYear.Year;
    }


}