using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Exercitiul_1
    {

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        string formattedString = string.Format("[{0}, {1}]", i, j);
                        Console.WriteLine(formattedString);

                     
                    }
                }

            }
            return nums;
        }
    }
}
