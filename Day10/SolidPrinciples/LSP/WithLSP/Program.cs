using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ipayment> payments = new List<Ipayment>
            {
                new CardPayment(),
                new UpiPayment(),
            };

            foreach (var payment in payments)
            {
                payment.PaymentProcosessor(100);
            }

            // COD handled separately if needed
            CashOnDelivery cod = new CashOnDelivery();
            cod.ConfirmCOD(100);

        }
    }
}
