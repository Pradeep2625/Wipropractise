using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandline
{
    [Serializable]
    internal class EmploySerializer
    {

        public  int employid { get; set; }
        public string emplyname { get; set; }
        public string employtype { get; set; }

        public override string ToString()
        {
            return "employee details: "+employid +" " +emplyname+" "+employtype;
        }
    }

}
