using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Overload
    {
        void sum()
        {
            Console.WriteLine("o parameters");
        }
        void sum(int n)
        {
            Console.WriteLine("type of parameters different");
        }
        void sum(string s) 
        {
            Console.WriteLine("type of  parameters different");
        }
        void sum(string s, int n)
        {
            Console.WriteLine("order of parameters different");
        }
        static void Main(string[] args)
        {
            Overload ol = new Overload();
            ol.sum();
            ol.sum(1);
            ol.sum("pradeep");
            ol.sum("deepu", 2002);

        }

    }
}
