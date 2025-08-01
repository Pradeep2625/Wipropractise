using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithISP
{
    internal class BasicPrinter : IPritn
    {
        public void print()
        {
            Console.WriteLine("This is a Basic printer it only supports printing...."); ;
        }
    }
}
