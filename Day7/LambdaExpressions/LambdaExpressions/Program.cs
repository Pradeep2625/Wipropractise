using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>
            {
                new Employees(1,"pradeep","9381672625",80000),
                new Employees(2,"sai","9381672456",81234),
                new Employees(3,"hari","9381645565",72859),
                new Employees(4,"bobby","93816545",54789),
                new Employees(5,"uday","9381589632",88235),
                new Employees(6,"prasad","938168520",90023),
                new Employees(6,"rohit","9381625874",74896)

            };
            Console.WriteLine("using orderby");
            var result = employees.OrderBy(x => x.Empsalary);
           
            foreach (var employee in result)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("using selecting without filter ");
            var result1 = employees.Select(x => x);
            foreach (var emplist1 in result1)
            {
                Console.WriteLine(emplist1);
            }
            Console.WriteLine("partially printing selected items");
            var result2 = employees.Select(x => new { x.Empid, x.Empname });
            foreach (var emplist2 in result2)
            {
                Console.WriteLine(emplist2);
            }
            Console.WriteLine("prints the data using where clause when salary greater than 80k");
            var result3 = employees.Where(x => x.Empsalary >= 80000);
            foreach (var emplist3 in result3)
            {
                Console.WriteLine(emplist3);
            }
            Console.WriteLine("sorted using salary");
            employees.Sort(new ComparerInt());
            var result4 = employees.Select(x => x);
            foreach (var emplist4 in result4)
            {
                Console.WriteLine(emplist4);
            }
            Console.WriteLine("sorted using names");
            employees.Sort(new ComparerString());
            var result5 = employees.Select(x => x);
            foreach (var emplist5 in result5)
            {
                Console.WriteLine(emplist5);
            }

        }
    }
}
