using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDIP
{

    internal class Program
    {

        public static IPaymentGateway SelectPaymentMethod(string type)
        {

            switch (type.ToLower())
            {
                case "upi":
                    return new UPI();
                case "card":
                    return new Cards();
                default:
                    throw new NotSupportedException("payment method not supported.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter bill amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("select payment Method(UPI/card)");
            string paymentmethod = Console.ReadLine();
            IPaymentGateway gateway = SelectPaymentMethod(paymentmethod);
            
            gateway.GoForBill(amount);
        }
    }
}
