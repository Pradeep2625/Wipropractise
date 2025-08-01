using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Delegate1
    {
        public delegate void Mydelegate1();
        public delegate void Mydelegate2(int n);
        public static void Printval(int n)
        {
            if(n == 0 || n == 1)
            {
                Console.WriteLine("delegate with params");
            }
        }
        public static void Show()
        {
            Console.WriteLine("Delegate without passing params");
        }
        static void Main(string[] args)
        {
            Mydelegate1 obj1= new Mydelegate1(Show);
            obj1();
            Mydelegate2 obj2 = new Mydelegate2(Printval);
            obj2(1);

        }
    }
}
