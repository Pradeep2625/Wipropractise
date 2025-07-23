using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class prog2
    {
        void tocheck(int n)
        {
            if(n%2 == 0)
            {
                Console.WriteLine("Given number is even: "+n);
            }
            else
            {
                Console.WriteLine("Given number odd: "+n);
            }
            
        }
        static void Main(string[] args)
        {
            int n;
            prog2 program = new prog2();
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            program.tocheck(n);
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            program.tocheck(n);
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            program.tocheck(n);
        }
    }
}
