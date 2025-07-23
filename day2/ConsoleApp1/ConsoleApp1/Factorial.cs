using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Factorial
    {
        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                long result = CalculateFactorial(number);
                Console.WriteLine($"The factorial of {number} is {result}");
            }
            else
            {
                Console.WriteLine("Please enter a valid non-negative integer.");
            }
        }
        
    }
}
