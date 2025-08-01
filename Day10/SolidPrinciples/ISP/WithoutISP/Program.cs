using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("document name?");
            string docname = Console.ReadLine();
           SmallPrinter sp = new SmallPrinter();
            sp.Scan(docname);
            sp.Print(docname);
            sp.Fax(docname);
            AdvancedPrinter ap = new AdvancedPrinter();
            ap.Print(docname);
            ap.Fax(docname);
            ap.Print(docname);


        }
    }
}
