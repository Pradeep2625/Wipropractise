using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutOcp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationSystem ns = new NotificationSystem();
            Console.WriteLine("enter type");
            string type = Console.ReadLine();
            Console.WriteLine("enter message to sent");
            string message = Console.ReadLine();
            ns.Send(type, message);
        }
    }
}
