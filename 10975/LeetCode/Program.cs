using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            List<int> result2 = RemoveDuplicates(new List<int> { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Console.WriteLine(result2);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indexArray = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
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
        public static List<int> RemoveDuplicates(List<int> nums)
        {
            List<int> numsList = new List<int> ();
            for (int i = 1; i < nums.Count; i++)
            {                
                    if ( nums[i] != nums[i-1])
                    {
                    numsList.Add(nums[i]);
                    }                
            }
            return numsList;
        }
    }

}
