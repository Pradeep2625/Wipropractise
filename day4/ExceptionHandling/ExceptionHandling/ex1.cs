using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ex1
    {
        int a, b,c;
        void Trycatch()
        {
            try
            {
                Console.WriteLine("enter first number: ");
                a=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second number: ");
                b=Convert.ToInt32(Console.ReadLine());
                c=a/b;
                Console.WriteLine(c);
            }

            catch (DivideByZeroException e)
            {

                Console.WriteLine("divided by zero is not possible");
            }
            catch (FormatException e) 
            {
                Console.WriteLine("enter integer values");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("length exceeded");
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            ex1 ex1 = new ex1();
            ex1.Trycatch();
        }
    }
}
