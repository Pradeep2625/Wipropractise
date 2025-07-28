using Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Vendors
    {
        string vendorName;
        int vendorId;
        public string VendorName
        {
            set
            {
                vendorName = value;
            }
        }
        public int VendorId
        {
            set { vendorId = value; }
        }


        public override string ToString()
        {
            return "vendor name is "+vendorName +" "+ "vendor id is "+vendorId;
        }
    }


    internal class WriteOnlyProp
    {
        static void Main (string[] args)
        {

            Vendors[] v = new Vendors[]
            {
                new Vendors{VendorId=1,VendorName="pradeep"},
                new Vendors{VendorId=2,VendorName="deepu" },
                new Vendors{VendorId=3,VendorName="wipro"}
            };
            foreach(object vendor in v)
            {
                Console.WriteLine(vendor);
            }

        }
    }

}