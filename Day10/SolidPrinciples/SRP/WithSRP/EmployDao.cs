using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithSRP
{
    internal interface EmployDao
    {
        string AddEmploy(Models emp);
        List<Models> GetAllEmploys();
    }
}
