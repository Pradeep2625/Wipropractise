using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog5
    {
        void greetings(string name)
        {
            Console.WriteLine("hello"+" "+name);
        }
        static void Main(string[] args)
        {
            Prog5 program = new Prog5();
            program.greetings("pradeep");
        }
    }
}
