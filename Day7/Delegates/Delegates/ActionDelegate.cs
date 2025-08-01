using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class ActionDelegate
    {
        public static void ActionDelegate1(string Gender)
        {
            if (Gender.ToUpper() == "MALE" || Gender.ToUpper() == "FEMALE")
            {
                Console.WriteLine("Tell me Secret code to enter");
            }
            Console.WriteLine("not allowed");
        }
        public static void ActionDelegate2(int code)
        {
            Console.WriteLine("secret code match!! you are allowed...wlcm to Action Delegates");
        }

        static void Main()
        {
            Action<string> ad = ActionDelegate1;
            string Gender;
            Console.WriteLine("Enter sex");
            Gender = Console.ReadLine();
            ad(Gender);
            Action<int> ad1 = ActionDelegate2;
            int code = Convert.ToInt32(Console.ReadLine());
            ad1 += ActionDelegate2;
            ad1(code);
        }
    }
}
