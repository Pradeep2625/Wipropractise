using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class VotingException
    {
        public void Voting(int age)
        {
            if(age <= 18)
            {
                throw new OurOwnexp("not eligible for voting");
            }
            else
            {
                Console.WriteLine("eligible for voting");
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            VotingException ve = new VotingException();
            try
            {
                ve.Voting(age);
            }
            catch (FormatException e)
            {
                Console.WriteLine("enter correct format");
            }
            catch (OverflowException e)
            {

                Console.WriteLine("enter age above 18");
            }
        }
    }
}
