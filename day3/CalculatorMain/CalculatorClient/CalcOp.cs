using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMain;
namespace CalculatorClient
{
    internal class CalcOp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter values for a & b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Calculatorlogic cl = new Calculatorlogic();
            Console.WriteLine("sum of two numbers is" + cl.Sum(a,b));
            Console.WriteLine("sum of two numbers is" + cl.Subtract(a, b));
            Console.WriteLine("sum of two numbers is" + cl.Multiply(a, b));
            Console.WriteLine("sum of two numbers is" + cl.division(a, b));



        }
    }
}
