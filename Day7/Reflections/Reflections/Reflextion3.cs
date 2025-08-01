using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using System.Reflection;
[assembly: CLSCompliant(true)]
namespace Reflections
{
    [CLSCompliant(true)] //to check whether the method names are in correct format or not
    internal class Reflextion3
    {
        [Obsolete("Deprecated Method",false)]
        public void Method1()
        {

        }
        public void METHOD2()
        {

        }
    }
}
