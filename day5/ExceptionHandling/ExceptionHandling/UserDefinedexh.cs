using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class UserDefinedexh : ApplicationException
    {
        public UserDefinedexh(string error) : base(error) { }
    }
}
