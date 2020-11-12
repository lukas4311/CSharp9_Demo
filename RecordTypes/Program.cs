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

            // I think its right but compiler raising error
            //User user3 = user with { FirstName = "Paul" };
            //Console.WriteLine($"Jméno: {user3.FirstName} {user3.LastName}");
        }
    }
}
