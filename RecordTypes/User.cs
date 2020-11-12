namespace RecordTypes
{
    public record User
    {
        public string LastName { get; }
        public string FirstName { get; }

        public User(string first, string last) => (FirstName, LastName) = (first, last);

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}
