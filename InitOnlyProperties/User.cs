namespace InitOnlyProperties
{
    public class User
    {
        private readonly string firstName;
        private readonly string lastName;

        public string FirstName
        {
            get => firstName;
            init => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            init => lastName = value;
        }
    }
}
