using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLSP
{
    internal class UpiPayment : Ipayment
    {
        public void PaymentProcosessor(decimal amount)
        {
            Console.WriteLine("Upi Payment processing"+amount);
        }
    }
}
