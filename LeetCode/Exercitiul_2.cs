using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Exercitiul_2
    {
        public void StringManipulation(int x)
        {
            string xAsString = x.ToString();
            int[] xArray = new int[xAsString.Length];

            for(int i = 0; i < xAsString.Length; i++)
            {
                xArray[i] = int.Parse(xAsString[i].ToString());
            }
            Console.WriteLine("Array: [" + string.Join(", ", xArray) + "]");
            for(int i = 0;i < xArray.Length / 2; i++)
            {
                int temp = xArray[i];
                xArray[i] = xArray[xArray.Length - 1 - i];
                xArray[xArray.Length -i - 1]= temp;
            }
            Console.WriteLine("Reversed Array: [" + string.Join(", ", xArray) + "]");
        }
        public int ConvertArrayToInt(int[] array)
        {
            int result = 0;
            for(int i = 0; i < array.Length; i++)
            {
                result = result * 10 + array[i];
            }
            return result;
        }
    }
}
