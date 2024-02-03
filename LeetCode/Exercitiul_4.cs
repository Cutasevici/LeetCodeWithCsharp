using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Exercitiul_4
    {
       public void returnMaxNum(int[] Array)
        {
            int Max_Int = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > Max_Int)
                {
                    Max_Int = Array[i];
                }
            }

            Console.WriteLine(Max_Int);
        }
        public void returnMinNum(int[] Array)
        {
            int Min_Int = Array[0];
            for(int i = 0;i < Array.Length;i++)
            {
                if (Array[i] < Min_Int)
                {
                    Min_Int = Array[i];
                }
            }
            Console.WriteLine(Min_Int);
        }
        public void evenNumber(int[] Array)
        {
            int counter = 0;
            for(int i = 0;i<Array.Length;i++)
            {
                if (Array[i] % 2 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        public void averageOfArray(int[] Array)
        {
            int sum = 0;
            int average = 0;
            for(int i =0;i<Array.Length; i++)
            {
                sum += Array[i];
            }
            average = sum / Array.Length;
            Console.WriteLine(average);
        }
        public void drawing(int length)
        {
            for(int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= length - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
               Console.WriteLine();
            }
            for (int i = length; i >= 1; i--)
            {
                for (int j = 0; j < length - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        public void reverseArray(int[] Array)
        {
            int start = 0;
            int end = Array.Length - 1;
            Console.WriteLine("Original array:");
            foreach (var item in Array)
            {
                Console.Write(item + " ");
            }
            while (start < end)
            {
                int temp = Array[start];
                Array[start] = Array[end];
                Array[end] = temp;

                start++;
                end--;
            }
            
            Console.WriteLine("\nReverse array:");
            foreach(var item in Array)
            {
                Console.Write(item + " ");
            }
        }
        public void incrementArray(int[] Array,int incrementor) 
        {
            for(int i = 0;i < Array.Length;i++)
            {
                Array[i] += incrementor;
            }
            Console.WriteLine("\nIncremented Array");
            foreach(var item in Array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
