using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Control
    {
        void PrintOutput()

        {

            int num;

            for (num = 10; num <= 15; num++)

            {

                while (Convert.ToBoolean(num))

                {

                    do

                    {

                        Console.WriteLine(1);

                        if (!Convert.ToBoolean(num >> 1))

                            break;

                    } while (Convert.ToBoolean(1));

                    break;

                }

            }
        }
        static void Main(string[] args)

        {

            Control ctrl = new Control();

            ctrl.PrintOutput();

        }
    }

}
