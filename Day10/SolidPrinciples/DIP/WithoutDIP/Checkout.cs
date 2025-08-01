using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutDIP
{
    internal class Checkout
    {
        private Upi upi = new Upi();
        public void OrderCheckout(decimal amount)
        {
            upi.Phonepe(amount);
        }
    }
}
