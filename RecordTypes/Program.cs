using System;

namespace RecordTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Lukas", "Doe");
            User user2 = new User("Lukas", "Doe");

            var (firstName, lastName) = user2;

            Console.WriteLine(user.Equals(user2));
            Console.WriteLine($"Jméno: {firstName} {lastName}");

            // Records are immutable
            //user2.FirstName = "Jmeno";

            Person person = new Person("Jmeno", "Prijmeni");
            var (personFirstName, personLastName) = person;

            Person person2 = person with { LastName = "Test" };

            Console.WriteLine($"Jméno: {personFirstName} {personLastName}");
            Console.WriteLine($"Jméno: {person2.FirstName} {person2.LastName}");
        }
    }
}
