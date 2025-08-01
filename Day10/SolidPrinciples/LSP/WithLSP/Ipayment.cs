using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLSP
{
    internal interface Ipayment
    {
        void PaymentProcosessor(decimal amount);
    }
}
