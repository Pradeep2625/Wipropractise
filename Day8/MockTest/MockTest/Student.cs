using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest
{
    public class Student
    {
        public int Studentid { get; set; }
      public  string Name { get; set; }
        public string City { get; set; }
        public string Standard { get; set; }
        public Student(int studentid,string name,string city,string standard) {
            Studentid = studentid;
            Name = name;
            City = city;
            Standard = standard;

        }    
    }
    



}
