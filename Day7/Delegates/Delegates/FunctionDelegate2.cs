using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class FunctionDelegate2
    {
        public static int Method1(string word1, string word2)
        {
            if(word1.Equals(word2))
            {
                return 0;
            }
            return 1;
        }
        public static int Method2(int num1, int num2)
        {
            return num1 + num2;
        }
        public static bool Method3 (string word1,string word2)
        {
            return word1==word2 ? true : false;
        }
        static void Main ()
        {
            Func<int, int,int> fd1 = Method2;
            Console.WriteLine("enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fd1(num1, num2));
            Func<string, string, int> fd2 = Method1;
            Console.WriteLine("enter name1");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter name2");
            string name2 = Console.ReadLine();
            Console.WriteLine(fd2(name1,name2));
            Func<string , string, bool> fd3 = Method3;
            Console.WriteLine(fd3(name1,name2));
        }
    }
}
