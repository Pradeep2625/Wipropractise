using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hellowolrd!welcome to dotnet");
            Calculator cal = new Calculator();
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cal.Add(num1, num2));
            Console.WriteLine(cal.Subtract(num1, num2));
            Console.WriteLine(cal.Multiply(num1, num2));
            Console.WriteLine(cal.Divide(num1,num2));




        }
    }
}
