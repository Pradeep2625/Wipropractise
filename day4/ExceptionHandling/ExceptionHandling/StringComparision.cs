using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class StringComparision
    {
        static void Main(string[] args)
        {
            StringComparision sc = new StringComparision();
            String a = "pradeep";
            String b = "pradeep";
            object c = "pradeep";
            object d = "prdeep";
            Console.WriteLine(a==b);
            Console.WriteLine(a==c);
            Console.WriteLine(c==d);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(b.Equals(c));
            Console.WriteLine(c.Equals(d));
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());






        }
    }
}
