using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Thiskeyword
    {
        int a, b;
        public Thiskeyword()
        {
            a=5;
            b=10;
        }
        public Thiskeyword(int a, int b)
        {
            this.a=a;
            this.b=b;
        }
        public void display()
        {
            Console.WriteLine("the value of a is " +a + " & " + "the value of b is "+b);
        }
        static void Main(string[] args)
        {
            Thiskeyword tk = new Thiskeyword();
            tk.display();
            Thiskeyword tk1 = new Thiskeyword(30,50);
            tk1.display();
            
        }
    }
}
