using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Calculator
    {
        void add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }
        void subtract(int a, int b)
        {
            Console.WriteLine("Difference: " + (a - b));
        }
        void multiply(int a, int b)
        {
            Console.WriteLine("Product: " + (a * b));
        }
        void divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine("Quotient: " + (a / b));
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }

        static void main(string[] args)
        {
            Console.WriteLine("hello world! welcome to dotnet");
            Calculator calculator = new Calculator();
            // You can add methods to the Calculator class and call them here
            calculator.add(10, 5);
            calculator.subtract(10, 5);
            calculator.multiply(10, 5);
            calculator.divide(10, 5);
            calculator.divide(10, 0); // Test division by zero
        }
    }
}
