using System;
using System.Collections.Generic;

namespace StaticAnonymousFunctions
{
    class Program
    {
        const string message = "{0} is awaiable country to travel while COVID";

        static void Main(string[] args)
        {
            PromoteCountry(static country => string.Format(message, country));
        }

        static void PromoteCountry(Func<string, string> func)
        {
            var countries = new List<string> { "Canada", "Russia", "Japan" };

            foreach (var country in countries)
                Console.WriteLine(func(country));
        }
    }
}
