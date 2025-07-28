using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Rabbit : IOne
    {
        void IOne.Attck()
        {
            Console.WriteLine("i dont harm any animal");
        }

        void IOne.Eat()
        {
            Console.WriteLine("i am a vegeterian");
        }

        void IOne.Makesound()
        {
            Console.WriteLine("i make sound with very low voice");
        }
    }
}
