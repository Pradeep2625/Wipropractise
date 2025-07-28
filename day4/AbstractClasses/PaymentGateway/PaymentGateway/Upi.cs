using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway
{
    internal class Upi : Payment
    {
        string upi_id;

        public override void PaymentStatus()
        {
            throw new NotImplementedException();
        }

        public void phonepe()
        {
            Console.WriteLine("enter upi id: ");
            upi_id = Console.ReadLine();
            if (upi_id == null | upi_id.Length <= 10)
            {
                Console.WriteLine("transaction failed..retry");
            }
            else
            {
                Console.WriteLine("payment successfull...");
            }

        }
    }
}
