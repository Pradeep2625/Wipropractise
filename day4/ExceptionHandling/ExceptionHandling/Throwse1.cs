using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Throwse1
    {
        public void Tocheck(int age)
        {
            if (age<0)
            {
                throw new StackOverflowException("enter values greater than 0");
            } else if (age == 0)
            {
                throw new FormatException("enter correct format");
            }
            else
            {
                Console.WriteLine("got it!!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter numer");
            int n = Convert.ToInt32(Console.ReadLine());
            Throwse1 t = new Throwse1();
            try
            {
                t.Tocheck(n);
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
