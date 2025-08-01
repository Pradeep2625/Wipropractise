using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class Reflextionex1
    {
        public int a;
        public int b;
        public static int c;
        public void Display()
        {
            a = 10;
            b = 20;
        }
        public void Display2()
        {
            string name1 = "pradeep";
            string name2 = string.Empty;

        }
        public void Display3()
        {
            double number = 20.8;
            char[] chars = new char[] { '0', '1' };
        }
        public void Generics()
        {
            List<string> list = new List<string>();
            list.Add("deepu");
            list.Add("pradeep");
           
        }
    }
}
