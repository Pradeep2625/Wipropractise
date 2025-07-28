using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            Console.WriteLine("Enter string:");
            string text = Console.ReadLine();
            p.TestPalindrome(text);
            Nonrepeatingchars np = new Nonrepeatingchars();
            np.NonRepeatingchars(text);
            Anagrams a = new Anagrams();
            Console.WriteLine("enter word1: ");
            string word1=Console.ReadLine();
            Console.WriteLine("enter word1: ");
            string word2=Console.ReadLine();
            a.CheckAnagram(word1, word2);
        }
    }
}
