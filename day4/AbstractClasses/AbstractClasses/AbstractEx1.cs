using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal abstract class AbstractEx1
    {
        public void ConcreteMethod()
        {
            Console.WriteLine("normal method in abstract class");
        }
        public abstract void AbstractMethod();
    }
}
