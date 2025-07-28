using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Models
{
    [Serializable]
    public class EmployeModels
    {
        public int Employeid { get; set; }
        public string Employname { get; set; }
        public string Employedesig { get; set; }
        public double Employesalary { get; set; }
        public string Employecity { get; set; }
       public EmployeModels() { }

        public EmployeModels(int employeid,string employname, string employedesig, double employesalary, string employecity)
        {
            Employeid = employeid;
            Employname = employname;
            Employedesig = employedesig;
            Employesalary = employesalary;
            Employecity = employecity;
        }
        public override string ToString()
        {
            return $" Employe id: {Employeid} " +" "+
                $" Employer Name: {Employname} " +" "+
                $" Employer Designation: {Employedesig} " +" "+
                $" Employer Salary: {Employesalary} " +" "+
                $" Employer City:{Employecity}";
        }
    }
}
