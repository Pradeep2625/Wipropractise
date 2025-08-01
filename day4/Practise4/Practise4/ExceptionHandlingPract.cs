using System;
using System.IO;
namespace Practise4
{
    public class ExceptionHandlingPract
    {
        static void HandleIndexOutOfRange()
        {
            try
            {
                int[] arr = new int[2];
                int val = arr[5];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range error: " + e.Message);
            }
        }

        static void HandleDivideByZero()
        {
            try
            {
                int a = 100, b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero error: " + e.Message);
            }
        }

        static void HandleFileNotFound()
        {
            try
            {
                File.OpenRead("notfound.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found error: " + e.Message);
            }
        }

        public static void Main(string[] args)
        {
            // Implement exception handling
            // Complete the code below to demonstrate various aspects of exception handling
            ExceptionHandlingPract exceptionHandlingPract = new ExceptionHandlingPract();
            // args[0] = Console.ReadLine();

            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "IndexOutOfRangeException":
                        // Trigger IndexOutOfRangeException
                        HandleIndexOutOfRange();
                        break;
                    case "DivideByZeroException":
                        HandleDivideByZero();
                        break;
                    case "FileNotFoundException":
                        // Trigger FileNotFoundException
                        HandleFileNotFound();
                        break;
                }
            }
        }
    }
}