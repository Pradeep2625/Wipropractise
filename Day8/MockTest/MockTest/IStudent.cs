using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest
{
    public interface IStudent
    {
        
        //public string AddStudent();
        List<Student> ShowStudents();
        public string DismissStudent(int studentid);
        public Student SearchStudent(int studentid);
    }
}
