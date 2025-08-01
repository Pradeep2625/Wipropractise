using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NullableConcept
{
    internal class NullCoalescing
    {
        
        
        static void Main()
        {
            // Null Coalescing Operator Example
            // The null-coalescing operator (??) is used to define a default value for nullable types.
            // If the left-hand operand is null, the right-hand operand is returned.
            string S1 = null;
            string S2 = "hello";
            string S3 = "welcome";
            string S4 = "bye";
            
            Console.WriteLine(S1 ?? S2);    //prints "hello" since S1 is null
            Console.WriteLine(S2 ?? S3);    //prints "hello" since S2 is not null
            Console.WriteLine(S3 ?? S4);    //prints "welcome" since S3 is not null
            Console.WriteLine(S4 ?? S1);   //prints "bye" since S4 is not null

        }
    }
}
