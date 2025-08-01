using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithOcp
{
    internal class Email : INotificationSystem
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Email msg sent " + message);
        }
    }
}
