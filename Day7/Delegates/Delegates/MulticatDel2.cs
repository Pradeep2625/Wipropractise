using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class MulticatDel2
    {
        public delegate void MulticastDelegate();
        public static void Show()
        {
            Console.WriteLine("method1 that refers MulticatDelegate");
        }
        public static void Display()
        {
            Console.WriteLine("method2 that refers MulticatDelegate");
        }
        public static void Print()
        {
            Console.WriteLine("method3 that refers MulticatDelegate");
        }
        static void Main(string[] args)
        {
            MulticastDelegate[] obj =
            {
               new MulticastDelegate(Show),
               new MulticastDelegate(Display),
               new MulticastDelegate(Print)

            };
            Console.WriteLine(" 'this proves that multicastdelegates' ");
            foreach (MulticastDelegate obj1 in obj)
            {
                obj1();
            }
        }
    }
}
