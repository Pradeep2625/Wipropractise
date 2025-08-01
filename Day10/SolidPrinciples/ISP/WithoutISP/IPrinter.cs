using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutISP
{
    internal interface IPrinter
    {
        void Print(string documentname);
        void Scan(string documentname);
        void Fax(string documentname);
    }
}
