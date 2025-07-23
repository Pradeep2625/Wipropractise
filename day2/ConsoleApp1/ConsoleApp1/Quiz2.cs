using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Quiz2
    {
        static void Main(string[] args)
        {


            int num1 = -2;

            int num2 = -1;


            if (Convert.ToBoolean(num1-- == --num2)){

                Console.WriteLine("If Condition is True");
            }

            else
            {
                Console.WriteLine("If Condition is False");
            }
        }
    }
}
