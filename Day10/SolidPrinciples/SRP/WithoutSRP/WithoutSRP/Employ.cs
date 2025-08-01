using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutSRP
{
    internal class Employ
    {
        public int Empdid {  get; set; }
        public string Empname { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }

        //constructor
        public Employ(int empid,string empname,string desig,decimal salary) 
        {
            Empdid = empid;
            Empname = empname;
            Designation = desig;
            Salary = salary;
        }
        static List<Employ> employlist;
        public Employ() {
            employlist = new List<Employ>();
        }
        public override string ToString()
        {
            return " empid: "+Empdid + "empname:" + Empname + "empdesig: " + Designation + "empsalary" + Salary ;
        }

        
        public List<Employ> AddEmploy(Employ emp)
        {
            employlist.Add(emp);
            return employlist;
        }
        public List<Employ> ShowEmploys()
        {
            return employlist;
        }
    }
}
