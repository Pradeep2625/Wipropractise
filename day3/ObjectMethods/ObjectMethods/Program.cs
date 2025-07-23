using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ emp1 = new Employ("pradeep", "rajahmundry","devops",21);
            Console.WriteLine(emp1);
            Employ emp2 = new Employ("deepu", "kkd", "cloud", 22);
            Console.WriteLine(emp2);

        }
    }
}
