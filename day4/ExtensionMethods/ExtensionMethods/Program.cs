using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Sum(5, 7));
            Console.WriteLine(calculator.Sub(5, 7));
            Console.WriteLine(calculator.Mul(5, 7));
            Console.WriteLine(calculator.Div(5, 7));
            Console.WriteLine(calculator.Remainder(5, 7));
   
        }
    }
}
