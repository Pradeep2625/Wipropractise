using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cards card = new Cards();
            Upi upi = new Upi();
            Console.WriteLine("select payment method upi/cards :");
            string type = Console.ReadLine();
            if(type == "upi")
            {
                Console.WriteLine("redirecting...");
                upi.phonepe();
            }
            else if(type =="cards")
            {
                card.PaymentStatus();
            }
            else
            {
                Console.WriteLine("failed to process..");
            }

        }
    }
}
