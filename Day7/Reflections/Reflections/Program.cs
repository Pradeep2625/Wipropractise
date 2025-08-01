using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type tp = typeof(Reflextionex1);
            Console.WriteLine("All Methods from reflextionex1");
            foreach (MethodInfo mi in tp.GetMethods())
            {
                Console.WriteLine(mi);
            }
            Console.WriteLine("All class level fields from reflextionex1 ");
            foreach (FieldInfo fi in tp.GetFields())
            {
                Console.WriteLine(fi);
            }
            Console.WriteLine("to get all types from the student class");
            Assembly execution = Assembly.GetExecutingAssembly();
            Type[] types = execution.GetTypes();
            foreach (var ob in types)
            {
                Console.WriteLine(ob.Name);
                Console.WriteLine("Display Methods of Assembly...");
                MethodInfo[] methods = ob.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        Console.WriteLine(arg.Name + "   " +arg.ParameterType);
                    }
                }
            }
        }

    }
}
