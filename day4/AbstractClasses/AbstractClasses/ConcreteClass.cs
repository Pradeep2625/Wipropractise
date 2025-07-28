using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class ConcreteClass : AbstractEx1
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("this is abstract method implemented in concrete class which extends abstract class");
        }
    }
}
