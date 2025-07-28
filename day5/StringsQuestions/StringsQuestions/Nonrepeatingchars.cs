using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsQuestions
{
    internal class Nonrepeatingchars
    {
        public void NonRepeatingchars(string text)
        {
            string nonrepeat = "";

            for (int i = 0; i<text.Length-1; i++)
            {
                bool ifunique = true;
                for (int j=0; j <text.Length;j++)
                {
                    if (i!=j && text[i]==text[j])
                    {
                        ifunique = false; 
                        break;
                    }
                }
                if (ifunique)
                {
                    nonrepeat += text[i];
                    
                }     
                
            }
            if (nonrepeat=="")
            {
                Console.WriteLine("no repeating characters found");
            }
            else
            {

                Console.WriteLine(nonrepeat);
            }
        }
    }
}
