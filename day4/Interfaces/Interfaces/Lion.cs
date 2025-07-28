using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Lion : IOne
    {
        void IOne.Attck()
        {
            Console.WriteLine("i can attack becaus i am a kingle of jungle......");
        }

        void IOne.Eat()
        {
            Console.WriteLine("i can eat by hunting only.......");
        }

        void IOne.Makesound()
        {
            Console.WriteLine("i am best to roarr.....");
        }
    }
}
