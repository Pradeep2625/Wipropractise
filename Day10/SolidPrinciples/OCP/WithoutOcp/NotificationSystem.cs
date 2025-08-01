using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutOcp
{
    internal class NotificationSystem
    {
        public void Send(string type,string message) 
        { 
            if(type == "whatsapp")
            {
                Console.WriteLine("sending whatsapp message "+message);
            }
            else if (type == "Email")
            {
                Console.WriteLine("sending Email:" + message);
            }
            else if(type =="Instagram")
            {
                Console.WriteLine("sending Instagram message "+message);
            }
            else if (type == "teams")
            {
                Console.WriteLine("sending teams message "+message);
            }
            else
            {
                Console.WriteLine("unknown notification type");
            }
        }


    }
}
