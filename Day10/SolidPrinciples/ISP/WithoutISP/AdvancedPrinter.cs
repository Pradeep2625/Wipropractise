using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutISP
{
    internal class AdvancedPrinter : IPrinter
    {
        public void Fax(string documentname)
        {
            Console.WriteLine($"{documentname} fax sending......");
        }

        public void Print(string documentname)
        {
            Console.WriteLine($"{documentname} printing......");
        }

        public void Scan(string documentname)
        {
            Console.WriteLine($"{documentname} scaning......");
        }
    }
}
