using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    internal class Milestoneprep
    {
        public string RemoveWhitespace(string input)
        {
            if (input == null)
                Console.WriteLine("String should be not null");
            return input.Replace(" ","");
        }
        public bool ContainsExample(string input, string value)
        {
            if (input == null || value == null)
                Console.WriteLine("String should be not null");
            return input.Contains(value);
        }
        public string CaseConvertion(string input)
        {
            char[] charArray = input.ToCharArray();
            for(int i=0; i<input.Length; i++)
            {
                if(char.IsUpper(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
                else if (char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }
            return new string(charArray);

        }
        static Dictionary<char,int> CountLetter(string input)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach(char count in input)
            {
                if(char.IsLetter(count))
                {
                    if(letterCount.ContainsKey(count))
                    {
                        letterCount[count]++;
                    }
                    else
                    {
                        letterCount[count] = 1;
                    }
                }
            }
            return letterCount;
        }
        static void Main(string[] args)
        {
            Milestoneprep milestonePrep = new Milestoneprep();
            string input = "Hello World";
            string noWhitespace = milestonePrep.RemoveWhitespace(input);
            Console.WriteLine($"Input without whitespace: {noWhitespace}");
            string value = "World";
            bool containsValue = milestonePrep.ContainsExample(input, value);
            Console.WriteLine($"Does the input contain '{value}'? {containsValue}");
            string caseConverted = milestonePrep.CaseConvertion(input);
            Console.WriteLine($"Case converted input: {caseConverted}");
            string letterCountInput = "Hello World";
            Dictionary<char, int> letterCount = CountLetter(letterCountInput);
            Console.WriteLine("Letter count:");
            foreach (var kvp in letterCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
