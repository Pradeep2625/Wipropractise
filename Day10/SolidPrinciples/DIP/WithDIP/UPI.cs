using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDIP
{
    internal class UPI : IPaymentGateway
    {
        public void GoForBill(decimal amount)
        {
            Console.WriteLine("select upi(phonepe/gpay/cred) ");
            string type = Console.ReadLine().ToLower();
            if (type == "phonepe")
            {
                Console.WriteLine($"{amount}bill processed using phonepe");
            }
            else if (type == "Gpay")
            {
                Console.WriteLine($"{amount}bill processed using Gpay");
            }
            else if(type == "Cred")
            {
                Console.WriteLine($"{amount}bill processed using cred");
            }
            else
            {
                Console.WriteLine($"payment type not supported");
            }
        }
    }
}
