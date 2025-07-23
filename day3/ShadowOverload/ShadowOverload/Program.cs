using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowOverload
{
    class Father
    {
        public void Properties()
        {
            Console.WriteLine("this belongs to father");
        }

    }
    class Son : Father
    {
        public new void Properties()
        {
            Console.WriteLine("both father son properties belongs to son");
            base.Properties();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            new Son().Properties();        
        }

    }
}
