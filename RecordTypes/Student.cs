namespace RecordTypes
{
    public record Student(string firstName, string lastName, string classNumber) : Person(firstName, lastName);
}
