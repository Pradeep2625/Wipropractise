using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Exceptions;
using Employee.Models;

namespace Employee.Dal
{
    internal interface IEmployeDao
    {
        string AddEmployeDao(EmployeModels employ);
        string DeleteEmployeDao(int empid);
        List<EmployeModels> ShowEmployeDao();
        string UpdateEmployeDao(EmployeModels updateemploy);
        EmployeModels SearchEmployeDao(int empid);
        string WriteToFileDao();
        string ReadFromFileDao ();
        
    }
}
