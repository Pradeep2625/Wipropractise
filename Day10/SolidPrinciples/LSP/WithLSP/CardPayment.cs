using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLSP
{
    internal class CardPayment : Ipayment
    {

        public void PaymentProcosessor(decimal amount)
        {
            Console.WriteLine("payment processed "+amount);
        }
    }

}
