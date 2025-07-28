using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway
{
    internal class Cards : Payment
    {
        string CardNumber;
        string CardType;
        int expyear;
        int cvv;
        int otp;
        public override void PaymentStatus()
        {
            Console.WriteLine("enter CardNumber : ");
            CardNumber = Console.ReadLine();
            Console.WriteLine("enter CardType : ");
            CardType = Console.ReadLine();
            Console.WriteLine("enter expyear : ");
            expyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter cvv : ");
            cvv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("verified card details successfully");
            Console.WriteLine("enter otp to process payment");
            otp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("payment successfull...");
            Console.WriteLine("Redirecting...");
        }
    }
}
