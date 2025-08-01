using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicPrinter bp = new BasicPrinter();
            bp.print();
            AdvancedPrinter ap = new AdvancedPrinter();
            ap.print();
            ap.Scanner();
            ap.Fax();
        }
    }
}
