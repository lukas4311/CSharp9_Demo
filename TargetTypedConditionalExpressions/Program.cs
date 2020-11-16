using System;

namespace TargetTypedConditionalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Target-typed conditional expressions!");

            int? number = true ? 1 : null;
        }
    }
}
