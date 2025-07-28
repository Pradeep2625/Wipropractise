using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Opearators
    {
        int a, b;
        int result,sum,subtract,mul,division,remainder;
        void Comoperators()
        {
            a=10;
            b=20;
            result +=a;

            Console.WriteLine("result=result+a ="+result);
            result +=b;
            Console.WriteLine("result=result+b ="+result);
            result -=b;
            Console.WriteLine("result=result-b ="+result);
            result *=a;
            Console.WriteLine("result=result*a ="+result);
            if (a==b)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (a!=b)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }



        }
        void arithmeticops()
        {
            a=50;
            b=30;
            sum = a+b;
            Console.WriteLine("sum is "+sum);
            subtract = a-b;
            Console.WriteLine("sum is "+subtract);
            mul = a*b;
            Console.WriteLine("sum is "+mul);
            division = a/b;
            Console.WriteLine("sum is "+sum);
            remainder = a%b;
            Console.WriteLine("sum is "+remainder);
        }
        void logicalops()
        {
            bool a = true;
            bool b = false;
            if(a & a)
            {
                Console.WriteLine("true if both are true");
            }
            else
            {
                Console.WriteLine("false if any one is false");
            }
            if (a | b)
            {
                Console.WriteLine("true if any one  is true");
            }
            else
            {
                Console.WriteLine("false only  both are false");
            }
            if(!(a && b))
            {
                Console.WriteLine("inner operations is false then becomes true");
            }
            else
            {
                Console.WriteLine("inner operations is true then becomes false");
            }
            

        }
        bool terinaryops()
        {
            bool a=true;
            bool b=false;
            return a&&b ? true : false;
        }
        static void Main(string[] args)
        {
            
            Opearators bo = new Opearators();
            Console.WriteLine("comparitive operators");
            bo.Comoperators();
            Console.WriteLine("arithimetic operators");
            bo.arithmeticops();
            Console.WriteLine("logical operators");
            bo.logicalops();
            Console.WriteLine("terinary operator");
            bo.terinaryops();

        }
    }
}
