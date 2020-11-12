namespace RecordTypes
{
    public record Student(string FirstName, string LastName, string ClassNumber) : Person(FirstName, LastName);
}
