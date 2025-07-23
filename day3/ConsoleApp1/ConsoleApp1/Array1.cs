using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Array1
    {

        void Array1Method(int row,int column)
        {
            
            int[,] arr = new int[row, column];

            row = arr.GetLength(0);
            column = arr.GetLength(1);
            Console.WriteLine("enter the element of the matrix:");
            for (int i = 0; i <row; i++)
            {
                for (int j=0; j<column; j++)
                {
                    Console.Write($"Element[{i},{j}] :");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i <row; i++)
            {
                for (int j = 0; j<column; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }


        }
        static void Main(string[] args)
        {
            int row, column;
            Console.WriteLine("Enter no.of row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no.of columns: ");
            column = Convert.ToInt32(Console.ReadLine());
            Array1 arr = new Array1();
            arr.Array1Method(row, column);
        }
    }
}
