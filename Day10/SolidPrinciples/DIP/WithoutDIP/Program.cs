using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Checkout c = new Checkout();
            c.OrderCheckout(2000);
        }
    }
}
