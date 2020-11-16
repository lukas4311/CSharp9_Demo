using System;

namespace TypePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type patterns!");
        }

        void M(object o1, object o2)
        {
            var t = (o1, o2);

            if (t is (int, string)) { 
                // test zda proměnnám sedí datový typ
            } 
            
            switch (o1)
            {
                case int: break; // test if o1 is an int
                case System.String: break; // test if o1 is a string
            }
        }

        private void M2(object o)
        {
            switch (o)
            {
                case int number:
                    Console.WriteLine($"Number + 1 = {number + 1}");
                    break;
                case string text:
                    Console.WriteLine($"Text + \"@\": {text + "@"}");
                    break;
            }
        }
    }
}
