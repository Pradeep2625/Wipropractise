using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Char Gender { get; set; }
        public string City { get; set; }
        public  Students(int id,string name,Char gender,string city)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.City = city;
        }
        public void Display()
        {
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"NAME : {Name}");
            Console.WriteLine($"GENDER : {Gender}");
            Console.WriteLine($"CITY : {City}");

        }
    }
    internal class ReadWriteProp
    {
        static void Main(string[] args)
        {
            Students s = new Students(1,"pradeep",'M',"Rajahmundry");
            Students s1 = new Students(2, "deepu", 'M', "Rajahmundry");
            Console.WriteLine("My Details:");
            //Console.WriteLine(s.ToString());
            s.Display();
            s1.Display();

        }
    }
}
