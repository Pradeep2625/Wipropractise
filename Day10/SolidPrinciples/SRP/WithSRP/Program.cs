using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models emp = new Models();
            emp.Empdid = 1;
            emp.Empname = "pradeep";
            emp.Designation = "devops";
            emp.Salary = 80000;
            EmployImpl employImpl = new EmployImpl();
            employImpl.AddEmploy(emp);
           var list = employImpl.GetAllEmploys();
            foreach (var employ in list)
            {
                Console.WriteLine(employ);
            }

        }
    }
}
