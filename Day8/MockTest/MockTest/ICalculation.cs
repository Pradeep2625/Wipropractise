using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest
{
    public interface ICalculation
    {
        public string Greeting();
        public int Sum(int a,int b);
        public int Sub(int a, int b);
        public int Mul(int a, int b);
    }
}
