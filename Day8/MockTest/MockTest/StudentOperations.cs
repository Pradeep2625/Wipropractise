using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest
{

    public class StudentOperations : IStudent
    {
        static List<Student> students;
        static StudentOperations()
        {
            students = new List<Student>
            {
                new Student(1, "Pradeep", "B.Tech", "RJY"),
                new Student(2, "Ravi", "MCA", "HYD"),
                new Student(2, "rohit", "BBA", "MDP"),
                new Student(2, "Bobby", "BBa", "MDP")

            };
        }
        

        public string DismissStudent(int studentid)
        {
            Student student = SearchStudent(studentid);
            foreach (Student student2 in students)
            {
                students.Remove(student2);
            }
            return "student not found";
            
        }

        public List<Student> ShowStudents()
        {
            return students;
        }
        public Student SearchStudent(int studentid)
        {
            Student studentfound = null;
            foreach (Student student in students)
            {
                if(student.Studentid == studentid)
                {
                    studentfound = student;
                    break;
                }
                
            }
            return studentfound;
        }
    }
}
