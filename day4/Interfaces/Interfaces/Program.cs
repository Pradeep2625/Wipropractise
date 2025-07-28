using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOne one = new Lion();
            one.Attck();
            one.Eat();
            one.Makesound();
            Console.WriteLine("rabbit_________________________________________");
          IOne rb = new Rabbit();
            rb.Attck();
            rb.Eat();
            rb.Makesound();




        }
    }
}
