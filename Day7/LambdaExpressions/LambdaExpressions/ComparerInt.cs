using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class ComparerInt : IComparer<Employees>
    {
       

        public int Compare(Employees x, Employees y)
        {
            return x.Empsalary>=y.Empsalary ? 1 : -1;
        }
    }
}
