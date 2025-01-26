using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = TwoSum(new int[] { 3,2,4 }, 6);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indexArray = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indexArray[0] = i;
                        indexArray[1] = j;                                              
                    }
                }
            }
            return indexArray;
        }
    }

}
