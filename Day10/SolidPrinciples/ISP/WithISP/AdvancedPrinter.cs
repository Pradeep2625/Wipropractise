using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithISP
{
    internal class AdvancedPrinter : IPritn, IScan, IFax
    {
        public void Fax()
        {
            Console.WriteLine("this is advanced printer fax will supports");
        }

        public void print()
        {
            Console.WriteLine("this is advanced printer printing will supports");
        }

        public void Scanner()
        {
            Console.WriteLine("this is advanced printer scanning will supports");
        }
    }
}
