using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMain
{
    public class Calculatorlogic
    {
        public int Sum(int a , int b)
        {
            return a+b;
        }
        public int Subtract(int a, int b)
        {
            return a-b;
        }
        public int Multiply(int a, int b)
        {
            return a+b;
        }
        public int division(int a, int b)
        {
            if (b>0)
            {
                return a/b;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
