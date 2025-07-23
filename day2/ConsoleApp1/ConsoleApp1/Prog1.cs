using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog1
    {
        void toCheck(int n)
        {
            
            if (n>0)
            {
                Console.WriteLine("positivenumber:"+n);
            }else if (n==0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("negativenumber:"+n);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Prog1 program = new Prog1();
            Console.WriteLine("enter number:");
            n = Convert.ToInt32(Console.ReadLine());
            program.toCheck(n);
            Console.WriteLine("enter number:");
            n = Convert.ToInt32(Console.ReadLine());
            program.toCheck(n);
            Console.WriteLine("enter number:");
            n = Convert.ToInt32(Console.ReadLine());
            program.toCheck(n);
        }
    }
}
