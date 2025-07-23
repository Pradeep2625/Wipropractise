using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Constructorex1
    {
        static Constructorex1()
        {
            Console.WriteLine("this is example for static constructor??? which is directly load by CLR during execution");
        }
        Constructorex1 ()
        {
            Console.WriteLine("this is example for instance constructor??? which is called automatically immediately when onject created");
        }
        Constructorex1 (int x)
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Constructorex1 c = new Constructorex1(5);
            Constructorex1 t = new Constructorex1();
            
        }
    }
}
