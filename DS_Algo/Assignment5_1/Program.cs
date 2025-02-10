namespace Assignment5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            Console.WriteLine(IsPalindrome(121));

            Console.WriteLine(" ---- Problem 2 ---- ");
            Console.WriteLine(SumNumber(1234));

            Console.WriteLine(" ---- Problem 3 ---- ");
            Console.WriteLine(ArrayTwice(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(ArrayTwice(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(ArrayTwice(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));

        }
        static bool IsPalindrome(int integer)
        {
            if (integer < 0)
            {
                return false;
            }
            int initialInteger = integer;
            int comparisonNumber = 0;
            while (integer > 0)
            {
                comparisonNumber = comparisonNumber*10 + integer % 10;
                integer = integer / 10;
            }
            return initialInteger == comparisonNumber;
        }
        static int SumNumber(int number)
        {
            int sum = 0;
            
            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            
            return sum;
        }
        static bool ArrayTwice(int[] nums)
        {
            bool contains = true;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }
            if (nums.Length == set.Count)
            {
                contains = false;
            }
            return contains;

        }
    }
}
