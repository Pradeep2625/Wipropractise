using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog4
    {
        void toPrint(int n)
        {
            //using for loop to print numbers from 1 to n
            for (int i=1; i<=n; i++)
            {
                Console.WriteLine(i);
            }
           
        }
        void countDown(int n)
        {
            while (n>0)
            {
                Console.WriteLine(n--);
            }
        }
        void sumOfNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of numbers from 1 to " + n + " is: " + sum);
        }

        static void Main(string[] args)
        {
            int n;
            Prog4 program = new Prog4();
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            program.toPrint(n);
            Console.WriteLine("Counting down from " + n + ":");
            program.countDown(n);
            Console.WriteLine("Boom....");
            Console.WriteLine("Enter a number to calculate the sum of numbers from 1 to that number:");
            n = Convert.ToInt32(Console.ReadLine());
            program.sumOfNumbers(n);
            
            

        }
    }
}
