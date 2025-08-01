using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ emp = new Employ();  // Object used to access methods
            emp.AddEmploy(new Employ(1, "pradeep", "Software Engineer", 80000));
            emp.AddEmploy(new Employ(2, "deepu", "Project Manager", 70000));
            List<Employ> employList = emp.ShowEmploys();
            foreach (Employ employ in employList)
            {
                Console.WriteLine(employ);
            }

        }
    }
        
    
}
