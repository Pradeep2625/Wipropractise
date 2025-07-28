using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StaticExamples
{
    internal class StaticVariables
    {
        int nscount;
        static int scount;
        void Svar()
        {
            nscount++;
            scount++;
        }
        void Display()
        {
            Console.WriteLine("count value of a non static variable: "+nscount);
            Console.WriteLine("count value of a static variable: "+scount);
        }
        static void Main(string[] args)
        {
            StaticVariables sv1 = new StaticVariables();
            StaticVariables sv2 = new StaticVariables();
            StaticVariables sv3 = new StaticVariables();
            StaticVariables sv4 = new StaticVariables();
            sv1.Svar();
            sv2.Svar();
            sv3.Svar();
            sv4.Svar();
            sv1.Display();
            
        }
    }
}
