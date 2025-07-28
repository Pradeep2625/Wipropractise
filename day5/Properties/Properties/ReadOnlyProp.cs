using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class ReadOnlyProp
    {
        static void Main(string[] args)
        {
            BankAccount bc= new BankAccount();
            Console.WriteLine("account holder name"+bc.accountholdername);
            Console.WriteLine("account holder number"+bc.accountnumber);
            Console.WriteLine("ifsc code"+bc.ifsccode);
            
    }
        
        
    }
    class BankAccount
    {
        public long accountnumber { get;}=456;
        public string ifsccode = "sbin0045";
        public string accountholdername { get; } = "pradeep";
    }
}
