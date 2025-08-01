using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSRP
{
    internal class EmployImpl : EmployDao
    {
        List<Models> emplist = new List<Models>();
        public string AddEmploy(Models emp)
        {
            emplist.Add(emp);
            return "employ added successfully";

        }

        public List<Models> GetAllEmploys()
        {
            return emplist;
        }
    }
}
