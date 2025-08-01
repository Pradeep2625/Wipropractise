using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    using System;
    using System.Xml.Linq;

    class CustomCollection
    {
        // Define internal data structure
        // Complete Step 1:............
        private List<string> names = new List<string>();

        // Implement indexer
        // Complete Step 2:............

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < names.Count)
                    return names[index];
                else
                    throw new IndexOutOfRangeException("Index out of range");
            }
            set
            {
                if (index >= 0 && index < names.Count)
                    names[index] = value;
                else
                    throw new IndexOutOfRangeException("Index out of range");
            }
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Create instance of CustomCollection
            // Complete Step 7:............
            CustomCollection cc = new CustomCollection();

            // Loop to set and get values based on user input
            for (int i = 0; i < 3; i++)
            {
                // Prompt the user to set elements
                Console.WriteLine("Enter index to set:");
                // Complete Step 5:............
                
    
            Console.WriteLine("Enter value to set:");
                // Complete Step 6:............

                // Prompt the user to get the elements
                Console.WriteLine("Enter index to get:");
                // Complete Step 8:............
            }
        }
    }
}
