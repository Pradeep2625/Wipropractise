using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class FunctionDelegates1
    {
        public static string GoForVote(string name)
        {

            return "enter age for verifying";
        } 
        public static string Age(int age)
        {
            if(age >= 18)
            {
                return "eligible to vote";
            }
            return "not eligible to vote";
        }
        public static void Main()
        {
            Console.WriteLine("function delegate required return type");
            Func<string,string> fd1 = GoForVote;
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            Console.WriteLine(fd1(name));
            Func<int,string> fd2 = Age;
            //Console.WriteLine("enter age for verifying");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fd2(age));
        }
    }
}
