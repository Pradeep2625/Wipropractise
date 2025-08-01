using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class AnonymousDel1
    {
        public delegate void Anonymousdelegate(string text);
        static void Main()
        {
            Anonymousdelegate obj = delegate (string str)
            {
                Console.WriteLine("this is anonymous method that declared in main method"+" " +str);
            };
            obj("Anonymously printed");
        }
    }
    
}
