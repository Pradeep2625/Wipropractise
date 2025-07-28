using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    internal static class StaticClass
    {
        
        static void show()
        {
            Console.WriteLine("when we declares a class as static then method must be declared with static explicitly because non static methods were not allowed");
        }
        static void Main(string[] args)
        {
            StaticClass.show();
        }
    }
}
