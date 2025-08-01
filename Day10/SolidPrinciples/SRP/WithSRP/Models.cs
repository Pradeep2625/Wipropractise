using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSRP
{
    internal class Models
    {
        public int Empdid { get; set; }
        public string Empname { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return " empid: " + Empdid + " empname: " + Empname + " empdesig: " + Designation + " empsalary " + Salary;
        }
    }
}
