using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[2, 3];
            Console.WriteLine("Enter the elements of the 2D array (2 rows, 3 columns):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
