using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Predicatedelegate
    {
        public static bool PredicateM1(int num)
        {
            if(num > 0)
            {
                return true;
            }
            return false;
        }
        static void Main()
        {
            Predicate<int> pd = PredicateM1;
            Console.WriteLine("enter number greater than zero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pd(num));
        }
    }
}
