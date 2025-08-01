using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Employee.Dal
{
    public class EmployeImpl : IEmployeDao
    {
        static List<EmployeModels> employlist;
        public EmployeImpl()
        {
            employlist = new List<EmployeModels>();
        }
        public string AddEmployeDao(EmployeModels employ)
        {
            employlist.Add(employ);
            return "Employ added successfully......";
        }

        public string DeleteEmployeDao(int empid)
        {
            EmployeModels employfound = SearchEmployeDao(empid);
            if (employfound != null)
            {
                employlist.Remove(employfound);
                return "employ deleted successfully";
            }
            return "given employ id not found";

        }

        public string ReadFromFileDao()
        {
            FileStream fs = new FileStream(@"D:\OneDrive\Desktop\Wipropractise\EmployeProject\Employ.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            employlist = (List<EmployeModels>)bf.Deserialize(fs);
            Console.WriteLine(employlist);
            fs.Close();
            return "readingdone>>>>";
        }

        public EmployeModels SearchEmployeDao(int empid)
        {
            EmployeModels employfound = null;
            foreach (EmployeModels show in employlist)
            {
                if (show.Employeid == empid)
                {
                    employfound = show;
                }

            }
            return employfound;
        }

        public List<EmployeModels> ShowEmployeDao()
        {
            return employlist;
        }

        public string UpdateEmployeDao(EmployeModels updateemploy)
        {
            EmployeModels employfound = SearchEmployeDao(updateemploy.Employeid);
            if (employfound != null)
            {
                employfound.Employname = updateemploy.Employname;
                employfound.Employeid = updateemploy.Employeid;
                employfound.Employecity = updateemploy.Employecity;
                employfound.Employesalary = updateemploy.Employesalary;
                employfound.Employedesig = updateemploy.Employedesig;
                Console.WriteLine("successfully updated the record");
            }
            return "employ not found";

        }

        public string WriteToFileDao()
        {
            FileStream fs = new FileStream(@"D:\OneDrive\Desktop\Wipropractise\EmployeProject\employ.txt", FileMode.Create
                , FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, employlist);
            return "file created successfully";
        }
    }
}
