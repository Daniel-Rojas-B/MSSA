using System;

using System.Linq;
using System.Text;


namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = TwoSum(new int[] { 3,2,4 }, 6);
            Console.WriteLine($"[{result[0]}, {result[1]}]");

            int result2 = RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Console.WriteLine(result2);

            MergeArrays(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);

            Console.WriteLine(RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 },2));

            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));

        }
        public static bool IsPalindrome(string s)
        {
            string nonS = new string(s.Where(char.IsLetterOrDigit).ToArray());
            nonS = nonS.ToLower();
            StringBuilder sb = new StringBuilder();

            for (int i = nonS.Length - 1; i >= 0; i--)
            {
                sb.Append(nonS[i]);
            }

            if (nonS == sb.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != val)
                {
                    nums[k]=nums[i];
                    k += 1;
                }               
            }
            return k;
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
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++j] = nums[i];
                }
            }

            return j + 1;
        }
        public static void MergeArrays(int[] nums1, int m, int[] nums2, int n)
        {
            var start = 0;
            for (int i = m; i < nums1.Length; i++)
            {
                nums1[i] = nums2[start];
                start++;
            }
            Array.Sort(nums1);
            foreach (int num in nums1)
            {
                Console.WriteLine(num);
            }
        }
    }

}
