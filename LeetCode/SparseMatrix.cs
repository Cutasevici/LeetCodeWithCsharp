using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SparseMatrix
    {
        private int numRows;
        private int numCols;
        private double[] values;
        private int[] rowIndices;
        private int[] colIndices;

        public SparseMatrix(int numRows, int numCols, double[] values, int[] rowIndices, int[] colIndices)
        {
            this.numRows = numRows;
            this.numCols = numCols;
            this.values = values;
            this.rowIndices = rowIndices;
            this.colIndices = colIndices;
        }

        public void Display()
        {
            int currentIndex = 0;

            for(int i = 0; i < numRows; i++)
            {
                for(int j = 0;j < numCols; j++)
                {
                    if(currentIndex< values.Length && i == rowIndices[currentIndex]
                        && j == colIndices[currentIndex])
                    {
                        Console.Write(values[currentIndex] + "\t");
                        currentIndex++;
                    }
                    else
                    {
                        Console.Write("O\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
