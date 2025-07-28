using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Exceptions
{
    public class EmployExceptions : ApplicationException
    {
        public EmployExceptions() { }
        public EmployExceptions(string message) : base(message) { }
    }
}
