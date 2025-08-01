using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutISP
{
    internal class SmallPrinter : IPrinter
    {
        public void Fax(string documentname)
        {
            Console.WriteLine("Fax not supported in this printer");
        }

        public void Print(string documentname)
        {
            Console.WriteLine($"{documentname} printing...."); ;
        }

        public void Scan(string documentname)
        {
            Console.WriteLine("scan not supported in this printer");
        }
    }
}
