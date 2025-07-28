using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    internal class StaticMethod
    {
        static void smethod()
        {
            Console.WriteLine("this is static method this method only be called using class name i.e classname.methodname()");
        }
        void nsmethod()
        {
            Console.WriteLine("this is non static method usually which can be called by creating an object");
        }
        static void Main(string[] args)
        {
            StaticMethod sm = new StaticMethod();
            sm.nsmethod();
            StaticMethod.smethod();
        }
    }
}
