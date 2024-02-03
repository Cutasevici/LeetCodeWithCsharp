using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LIL
    {
        public void DisplayMatrix(List<List<int>> matrix)
        {
            Console.WriteLine("Matrix: ");
            foreach(var row in matrix)
            {
                foreach(var element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
        public void DisplayMainDiagonal(List<List<int>> matrix)
        {
            Console.WriteLine("Main Diagonal: ");
            for(int i = 0; i < matrix.Count; i++)
            {
                if(i < matrix[i].Count)
                {
                    Console.Write(matrix[i][i]+ " ");
                }

            }
            Console.WriteLine();
        }
        public void DisplaySparse(List<List<int>> matrix)
        {
            int size = Math.Min(matrix.Count, matrix[0].Count);

            int[] values = new int[size];
            int[] rowIndices = new int[size];
            int[] colIndices = new int[size];

            for(int i = 0; i < size;i++)
            {
                values[i] = matrix[i][i];
                rowIndices[i] = i;
                colIndices[i] = i;
            }

            Console.WriteLine("Sparse Diagonal Matrix (CSR format):");
            for(int i = 0;i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (i == rowIndices[j] && j == colIndices[j])
                        Console.Write(values[j] + "\t");
                    else
                        Console.Write("O\t");
                }
                Console.WriteLine() ;
            }
        }
    }
}
