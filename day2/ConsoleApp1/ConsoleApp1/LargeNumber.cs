using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LargeNumber
    {
        void toPrintLargeNumber(int a,int b,int c)
        {
            int temp = a;
            if (a<=b)
            {
                temp=b;
            }
            if (b<=c)
            {
                temp=c;
            }
            
            Console.WriteLine("largestnumberis:"+temp);
        }
        static void Main(string[] args)
        {
           
            LargeNumber program = new LargeNumber();
            Console.WriteLine("enter a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            program.toPrintLargeNumber(a,b,c);


        }
    }
}
