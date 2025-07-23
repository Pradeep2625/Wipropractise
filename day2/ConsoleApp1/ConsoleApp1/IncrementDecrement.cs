using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IncrementDecrement
    {
        static void Main(string[] args)
        {
            int num1 = -2;
            int num2 = -1;

            int result1 = num1++;  // Post-increment
            Console.WriteLine(result1); // Output: 2
            int result2 = ++num1;  // Pre-increment
            Console.WriteLine(result2);// Output: 4
            int result3 = num2++;  // Post-decrement
            Console.WriteLine(result3); // Output: -2
            int result4 = ++num2;  // Pre-decrement
            Console.WriteLine(result4); // Output: 0
            
        }
    }
}
