using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Exceptions;
using Employee.Models;
using Employee.Dal;
using System.Runtime.Remoting.Messaging;
namespace Employee.Bal
{
    public class EmployBal
    {
        StringBuilder sb = new StringBuilder();
        public static EmployeImpl employimpldao;
        public EmployBal()
        {
            employimpldao = new EmployeImpl();
        }
        public List<EmployeModels> Showemploybal()
        {
            return employimpldao.ShowEmployeDao();
        }
        public string DeleteEmployDao(int empid)
        {
            return employimpldao.DeleteEmployeDao(empid);
        }
        public string UpdateEmployBal(EmployeModels updateemploy)
        {
            if (Validation(updateemploy)==true)
            {

                return employimpldao.UpdateEmployeDao(updateemploy);
            }
            throw new Exception(sb.ToString());
        }
        public EmployeModels SearchEmployBal(int empid)
        {
            return employimpldao.SearchEmployeDao(empid);
        }
        public string AddEmploy(EmployeModels employ)
        {
            if (Validation(employ)==true)
            {

                return employimpldao.AddEmployeDao(employ);
            }
            throw new Exception(sb.ToString());
        }
        public string ReadFromFileBal()
        {
            return employimpldao.ReadFromFileDao();
        }
        public string WriteToFileBal()
        {
            return employimpldao.WriteToFileDao();
        }
        public bool Validation(EmployeModels employ)
        {
            bool flag = true;
            if (employ.Employname.Length>15)
            {
                sb.Append("employename length exceeded!please enter below 15 chars, ");
                flag = false;
            }
            if (employ.Employeid<0)
            {
                sb.Append("enter employ id greater than  0! negative numbers are not allowed, ");
                flag = false;
            }
            if(employ.Employesalary<10000 || employ.Employesalary>100000)
            {
                sb.Append("enter salary between 10000 to 100000, ");
                flag = false;
            }
            return flag;
        }
        
    }
}
