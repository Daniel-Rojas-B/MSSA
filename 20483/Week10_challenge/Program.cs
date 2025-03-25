namespace Week10_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Problem 1 ----");
            Console.WriteLine(TwoStrings("abcd", "abcde"));
            Console.WriteLine(TwoStrings("", "y"));

            Console.WriteLine("---- Problem 2 ----");
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int m = 3;
            int[] nums3 = { 1 };
            int[] nums4 = {  };
            int a = 1;
            int b = 0;
            int[] nums5 = {0 };
            int[] nums6 = { 1 };
            int c = 0;
            int d = 1;
            TwoArrays(nums1, m, nums2, n);
            Console.WriteLine(string.Join(", ", nums1));
            TwoArrays(nums3, a, nums4, b);
            Console.WriteLine(string.Join(", ", nums3));
            TwoArrays(nums5, c, nums6, d);
            Console.WriteLine(string.Join(", ", nums5));


            Console.ReadKey();
        }

        static char TwoStrings(string s, string t)
        {
            Dictionary<char, int> cCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (cCount.ContainsKey(c))
                    cCount[c]++;
                else
                    cCount[c] = 1;
            }

            foreach (char c in t)
            {
                if (!cCount.ContainsKey(c) || cCount[c] == 0)
                    return c;
                cCount[c]--;
            }

            return 'a';
        }

        static void TwoArrays(int[] nums1, int m, int[] nums2, int n)
        {
            var start = 0;
            for (int i = m; i < nums1.Length; i++)
            {
                nums1[i] = nums2[start];
                start++;
            }
            Array.Sort(nums1);
            
        }
    }
}
            

