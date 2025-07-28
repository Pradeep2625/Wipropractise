using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsQuestions
{
    internal class Palindrome
    {
       
        public void TestPalindrome(string text)
        {
            string reversedtext = "";
            for(int i=text.Length-1;i>=0; i--)
                reversedtext += text[i];
            Console.WriteLine(reversedtext);
            if (reversedtext.Equals(text))
            {
                Console.WriteLine("given string is palindrom");
            }
            else
            {
                Console.WriteLine("given string is not a palindrom");
            }

        }
        
    }
}
