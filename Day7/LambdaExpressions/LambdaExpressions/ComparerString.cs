using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class ComparerString : IComparer<Employees>
    {
        public int Compare(Employees x, Employees y)
        {
            return x.Empname.CompareTo(y.Empname);
        }

      
    }
}
