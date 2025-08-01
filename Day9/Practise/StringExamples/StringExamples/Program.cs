using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    public delegate int Operations(int a, int b);
    class Program
    {
        // Implement delegate methods
        // Complete Step 2:............


        // Implement callback mechanism
        // Complete Step 3:............
        public static int Add(int a, int b)
        {
            
            return a+b;
        }
        public static int Subtract(int a, int b)
        {
           
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            
            return a / b;
        }
        
        static void Main(string[] args)
        {
            // Input handling
            // Complete Step 4:............
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operation: add, subtract, multiply, divide");
            
            string operation = Console.ReadLine().ToLower();
            if (operation == "add")
            {
                Console.WriteLine("Result: " + Add(num1, num2));
            }
            else if (operation == "subtract")
            {
                Console.WriteLine(Subtract(num1, num2));
            }
            else if (operation == "multiply")
            {
                Console.WriteLine(Multiply(num1, num2));
            }
            else if (operation == "divide")
            {
                Console.WriteLine(Divide(num1, num2));
            }
            else
            {
                Console.WriteLine("incorrect operation");
            }
            
            
            
            
            

            // Output handling
            // Complete Step 5:............
        }
    }
}
