using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Exercitiul_3
    {
        public void intoArray(int x)
        {
            string numString = Convert.ToString(x);
            int[] digits = new int[numString.Length];

            for(int i = 0; i < numString.Length; i++)
            {
                digits[i] = int.Parse(numString[i].ToString());

            }

            Console.WriteLine("Array of digits: ");
            foreach(int digit in digits)
            {
                Console.WriteLine(digit + " ");
            }
            
        }
        public void ArrayIterator(int[] Array)
        {
            for (int i = 0; i < Array.Length;i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
        public void reverseArray(int[] Array)
        {   
            int n = Array.Length;
            int[] reversedArray = new int[n];

            for(int i = n-1, j=0; i >= 0; i--,j++)
            {
                reversedArray[j] = Array[i];
              
                
            }
            Console.WriteLine("Reverse array: ");
            foreach (int element in reversedArray)
            {
                Console.WriteLine(element);
            }
            string reversedString = "";
            for(int i = n -1; i >= 0; i--)
            {
                reversedString += Array[i].ToString();
            }
            int reversedInteger = int.Parse(reversedString);

            Console.WriteLine("Reversed integer: " +  reversedInteger);
        }
    }
}
