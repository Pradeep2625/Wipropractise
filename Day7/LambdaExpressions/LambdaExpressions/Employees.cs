using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Employees
    {
        public int Empid {  get; set; }
        public string Empname { get; set; }
        public string Empphone { get; set; }
        public double Empsalary { get; set; }

        public Employees(int empid, string empname, string empphone, double empsalary)
        {
            Empid=empid;
            Empname=empname;
            Empphone=empphone;
            Empsalary=empsalary;
        }
        public override string ToString()
        {
            return "Empoyee Id" +" "+ Empid +" "+ "employee name" +" "+ Empname +" "+ "Employee phoneno"+" " +Empphone +" "+
                "employe salary" +" "+ Empsalary;
        }
    }
}
