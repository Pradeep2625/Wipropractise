using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise4
{
    using System;

    // Define PropertyDemo class
    public class PropertyDemo
    {
        // Define properties
        // Complete Step 1:............
        private int Num1 { get; set; }
        public int Num2 { get; set; }
        public PropertyDemo()
        {
            Num1=5;
            Console.WriteLine(+Num1);
            Console.WriteLine("Private Value");

        }

    }

    // Define StaticDemo class
    public class StaticDemo
    {
        // Define static members
        // Complete Step 2:............
        public static int Num1;
        public static int Num2;

        static StaticDemo()
        {
            Num1=10;
            Console.WriteLine("Static Constructor");

        }
        public static void Method()
        {
            
            Console.WriteLine("Static Method");

        }
    }

    // Define MathHelper static class
    public static class MathHelper
    {
        // Define static methods
        // Complete Step 3:............
        public static int Sum(int Num1, int Num2)
        {
            return Num1+Num2;

        }
        public static int Sub(int Num1, int Num2)
        {
            return Num1-Num2;

        }
        public static double Mul(int Num1, int Num2)
        {
            return Num1*Num2;

        }
    }

    public class Opeartion
    {
        public static void Main()
        {
            // Demonstrate usage
            // Complete Step 4:............
            Console.WriteLine(MathHelper.Mul(1, 2));
            Console.WriteLine(MathHelper.Sum(5, 2));
            Console.WriteLine(MathHelper.Sub(4, 2));
            //StaticDemo sd = new StaticDemo();
            PropertyDemo pd = new PropertyDemo();
            StaticDemo.Method();


        }
    }
}
