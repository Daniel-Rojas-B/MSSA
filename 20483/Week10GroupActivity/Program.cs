using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week10GroupActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Group challenge ---- ");

            int[] nums1 = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine(Sequence(nums1)); 

            int[] nums2 = { 0, 3, 7, 2, 5, 8, 6, 4, 0, 1 };
            Console.WriteLine(Sequence(nums2)); 

        }
        public static int Sequence(int[] nums)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(nums);
            // 0, 3, 7, 2, 5, 8, 6, 4, 1    take out the second 0
            int counter =0;

            foreach (int num in uniqueNumbers)
            {
                if (!uniqueNumbers.Contains(num - 1))
                {
                    int currentNum = num;
                    int startPoint = 1;

                    while (uniqueNumbers.Contains(currentNum + 1))
                    {
                        currentNum++;
                        startPoint++;
                    }

                    counter = Math.Max(counter, startPoint);
                }
            }
            return counter;
        }
    }
}
