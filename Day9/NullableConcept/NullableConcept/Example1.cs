using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableConcept
{
    internal class Example1
    {
        // Example of using nullable types in C#
        // This example demonstrates how to check if a nullable type has a value,
        // and how to assign a value if it does not.
        static void Main(string[] args)
        {
            int? nullableInt = null;
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"The value is: {nullableInt.Value}");
            }
            else
            {
                nullableInt = 10;
                Console.WriteLine("assigned value is :"+nullableInt);
            }
        }
    }
}
