using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TwoDimentionalArray
    {
        void multiDimentional(int row, int column)
        {
            int[,] array = new int[row, column];
            row=array.GetLength(0);
            column=array.GetLength(1);
            Console.WriteLine("enter elements of array:");
            for (int i = 0; i<row; i++)
            {
                for (int j = 0; j<column; j++)
                {

                    Console.Write($"Elemts[{i},{j}] :");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i<row; i++)
            {
                for (int j = 0; j<column; j++)
                {
                    Console.Write(array[i, j]);

                }
                Console.WriteLine();


            }


        }
        static void Main(string[] args)
        {
            int row, column;
            TwoDimentionalArray tda = new TwoDimentionalArray();
            Console.WriteLine("enter no of rows");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no of rows");
            column = Convert.ToInt32(Console.ReadLine());
            tda.multiDimentional(row, column);
        }
    }
}

