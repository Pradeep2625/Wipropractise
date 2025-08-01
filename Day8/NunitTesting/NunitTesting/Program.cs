using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorTest;
namespace NunitTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcMain cm = new CalcMain();
            cm.Dvision(10, 0);
        }
    }
}
