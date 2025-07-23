using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicle
    {
        int model, mnfyear;
        string make;
        public void engine()
        {
            Console.WriteLine("engine starting....");
        }
        public void accelerator()
        {
            Console.WriteLine("vehicle starts....");
        }
        public void brake()
        {
            Console.WriteLine("vehicle stops....");
        }
        
    }
    class Car : Vehicle
    {
        
        public void engine()
        {
            Console.WriteLine("car engine....");
            base.engine();
        }
    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            
            Car car = new Car();
            car.engine();

        }
    }
    
}
