using System;

namespace InitOnlyProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                FirstName = "Lukas",
                LastName = "Doe"
            };

            // Error property jde setnout jen pro inicializaci objektu pomocí object initializeru a nebo v kontruktoru
            //person.FirstName = "Name";
        }
    }
}
