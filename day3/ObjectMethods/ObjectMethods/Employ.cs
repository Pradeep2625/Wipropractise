using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal class Employ
    {
        string name, city, department;
        int empid;
        public Employ()
        {

        }
        
        public Employ(string name,string city,string department,int empid) 
        {
            this.name = name;
            this.city = city;
            this.department = department;
            this.empid = empid;
        }
        public override string ToString()
        {
            return "employee name is " +name+" " +"lives in "+city+" "+"and belong to " +department+" "+ "empoyee id is "+empid;
        }

    }
}
