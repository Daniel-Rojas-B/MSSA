using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignments_Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ----");
            IsPalindrome("eye");
            IsPalindrome("home");

            Console.WriteLine(" ---- Problem 2 ----");
            SumDigitsInString("1q2w3e");
            SumDigitsInString("L0r3m.1p5um");
            SumDigitsInString("");

            Console.WriteLine(" ---- Problem 3 ----");
            numsTarget(new int[] { 2,7,11,15},9);

        }
        static void IsPalindrome(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int j = s.Length - 1; j >= 0; j--)
            {
                sb.Append(s[j]);
            }
            if (s == sb.ToString())
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        static void SumDigitsInString(string s)
        {
            int sumDigits = 0;
            
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    sumDigits = sumDigits + int.Parse(c.ToString());
                }
            }
            Console.WriteLine(sumDigits);
        }
        static void numsTarget(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j =1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"[{i},{j}]");
                        break;
                    }
                }
            }
        }
    }
}
