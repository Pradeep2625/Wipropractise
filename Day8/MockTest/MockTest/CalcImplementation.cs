using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest
{
    public class CalcImplementation : ICalculation
    {
        public string Greeting()
        {
            return "Hello welcome Mock testing";
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Sub(int a, int b)
        {
            return b-a;
        }

        public int Sum(int a, int b)
        {
            return a;
        }
    }
}
