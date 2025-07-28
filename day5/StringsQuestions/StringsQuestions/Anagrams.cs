using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StringsQuestions
{
    internal class Anagrams
    {
  
        public void CheckAnagram(string word1,string word2)
        {
            
            if (word1.Length != word2.Length)
            {
                Console.WriteLine("not an anagram becuase of length of the two strings are not same");
            }
            
            char[] arr1 = word1.ToCharArray();
            char[] arr2 = word2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            if (arr1.SequenceEqual(arr2))
            {
                Console.WriteLine("anagram is possible with given words");
            }

        }
    }
}
