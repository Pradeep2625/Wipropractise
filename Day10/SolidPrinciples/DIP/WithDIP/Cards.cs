using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDIP
{
    internal class Cards : IPaymentGateway
    {
        public void GoForBill(decimal amount)
        {
            Console.WriteLine("select credit or debit card");
            string type = Console.ReadLine().ToLower();
            if(type == "debit")
            {
                Console.WriteLine($"please swipe {amount}");
            }
            else if(type == "credit")
            {
                Console.WriteLine($"Tap & pay {amount}");
            }
            else
            {
                Console.WriteLine("card not supports");
            }
        }
    }
}
