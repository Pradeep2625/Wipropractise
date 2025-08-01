using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLSP
{
    internal class CashOnDelivery
    {
        public void ConfirmCOD(decimal amount)
        {
            Console.WriteLine($"cod processed please handover the amount {amount} to delivery partner");
        }
    }
}
