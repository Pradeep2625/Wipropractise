using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type obj = typeof(Student);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] mYobjects = assembly.GetTypes();
            foreach (Type t in mYobjects)
            {
                Console.WriteLine( t);
            }
        }
    }
}
