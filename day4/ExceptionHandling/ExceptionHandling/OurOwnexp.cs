using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class OurOwnexp : ApplicationException
    {
        public OurOwnexp(string error) : base(error)
        {

        }
    }
}
