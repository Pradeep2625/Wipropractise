using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutLSP
{
    public class Payment
    {
        public virtual void Paymentprocessor(decimal amount)
        {
            Console.WriteLine("payment processed "+amount);
        }
    }

    class UpiPayment : Payment
    {
        public override void Paymentprocessor(decimal amount)
        {
            Console.WriteLine("up payment successfull with the amount: "+amount);
        }
    }

    class CreditCardPayment : Payment
    {
        public override void Paymentprocessor(decimal amount)
        {
            Console.WriteLine("up payment successfull with the amount: " + amount);
        }
    }

    class CashOnDelivery : Payment
    {
        public override void Paymentprocessor(decimal amount)
        {
            Console.WriteLine("not accepted cod");
        }
    }
}

