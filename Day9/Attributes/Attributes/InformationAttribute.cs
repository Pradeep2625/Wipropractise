using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method |
           AttributeTargets.Constructor, AllowMultiple = true)]
    internal class InformationAttribute : Attribute
    {
       public string InformationString { get; set; }
    }
}
