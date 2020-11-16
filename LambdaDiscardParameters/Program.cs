using System;
using System.Collections.Generic;

namespace LambdaDiscardParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labda discard parameters!");

            List<int> items = new List<int> { 1, 2, 3, 4, 5 };
            items.ForEach(_ => Console.WriteLine("Proste něco!!"));
        }
    }
}
