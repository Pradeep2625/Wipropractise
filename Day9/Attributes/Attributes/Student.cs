using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [Information(InformationString = "Class")]


    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public int RollNumber { get; set; }

        [Information(InformationString = "Constructor")]
        public Student(string name, int age, string grade, int rollNumber)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
            this.RollNumber = rollNumber;
        }
        [Information(InformationString = "DisplayInfo method")]
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}, Roll Number: {RollNumber}");
        }
    }

}
