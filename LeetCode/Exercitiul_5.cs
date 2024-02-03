using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Exercitiul_5
    {
        public void displayMatrix(int[,,] array)
        {
            int depth = array.GetLength(0);
            int rows = array.GetLength(1);
            int columns = array.GetLength(2);

            for (int d = 0; d < depth; d++)
            {
                Console.WriteLine($"Layer {d + 1}:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(array[d, i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
