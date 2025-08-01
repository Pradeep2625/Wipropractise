using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDIP
{
    internal interface IPaymentGateway
    {
        void GoForBill(decimal amount);
    }
}
