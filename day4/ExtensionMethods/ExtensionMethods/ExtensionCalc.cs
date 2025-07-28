using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class ExtensionCalc
    { 
        public static int Div(this Calculator cal ,int a, int b)
        {
            return a / b;
        }
        public static int Remainder(this Calculator cal, int a, int b)
        {
            return a % b;
        }
    }
}
