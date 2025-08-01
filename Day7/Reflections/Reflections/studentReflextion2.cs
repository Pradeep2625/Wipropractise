using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class studentReflextion2
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Gender { get; set; }
        public string City { get; set; }
        public studentReflextion2(int id,string name,string gender,string city)
        {
            Id = id;
            Name = name;
            Gender = gender;
            City = city;

        }
        public void ShowStudents()
        {
            Id = 0;
            Name = string.Empty;
            Gender= string.Empty;
            City = string.Empty;
        }
        public override string ToString()
        {
                return "id"+Id +"Name" +Name + "gender" + Gender + "city" + City;
        }
     }
}
