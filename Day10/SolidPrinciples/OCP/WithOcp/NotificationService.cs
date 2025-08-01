using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithOcp
{
    internal class NotificationService
    {
        public static INotificationSystem GetNotifier(string type)
        {
            switch (type.ToLower())
            {
                case "email":
                    return new Email();
                case "whatsapp":
                    return new Whatsapp();
                case "insta":
                    return new Instagram();
                default:
                    throw new NotSupportedException("Notification type not supported.");
            }
        }
        static void Main(string[] args)
        {
          
            
            Console.WriteLine("Enter message ");
            string message = Console.ReadLine();
            Console.WriteLine("choose applicaton to send message(whatsapp/Email/insta)");
            string application = Console.ReadLine();
            INotificationSystem notificationSystem = GetNotifier(application);
            notificationSystem.SendNotification(message);
            


        }
    }
}
