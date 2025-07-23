using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JaggedArray
    {
        void jaggedarr()
        {
            int[][] ja = new int[4][];

            for (int i = 0; i<4; i++)
            {
                Console.WriteLine($"enter number of the column {i}:");
                int col = Convert.ToInt32(Console.ReadLine());
                ja[i] = new int[col];

                
                    for (int j = 0; j<col; j++)
                    {
                        Console.Write($"Element [{i} {j}] :" );
                        ja[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                   
            }
            for (int i = 0; i<ja.Length; i++)
            {
                for(int j = 0; j<ja[i].Length; j++){
                    Console.Write(ja[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            JaggedArray ja = new JaggedArray();
            ja.jaggedarr();
        }
    }
}
