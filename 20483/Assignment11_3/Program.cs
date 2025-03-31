using System.Runtime.ExceptionServices;

namespace Assignment11_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            int[] numbers1 = new int[] { 40, 10, 20, 30 };
            Rank(numbers1);
            int[] numbers2 = new int[] { 100, 100, 100 };
            Rank(numbers2);
            int[] numbers3 = new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 };
            Rank(numbers3);

            Console.WriteLine(" ---- Problem 2 ---- ");
            int[] nums1 = new int[] { 3, 2, 3 };
            Console.WriteLine(Majority(nums1));
            int[] nums2 = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(Majority(nums2));


            Console.ReadLine();
        }
        public static void Rank(int[] arr)
        {
            int[] sortedArr = arr.ToArray();
            for (int i =0; i< sortedArr.Length-1;i++)
            {                 
                for (int j = 0; j < sortedArr.Length - i - 1; j++)
                {
                    
                    if (sortedArr[j] > sortedArr[j + 1])
                    {
                        int temp = sortedArr[j];
                        sortedArr[j] = sortedArr[j + 1];
                        sortedArr[j + 1] = temp;
                    }
                }
            }

            Dictionary<int, int> rankingDict = new Dictionary<int, int>();
            int rank = 1;
            for (int i = 0; i < sortedArr.Length; i++)
            {
                if (!rankingDict.ContainsKey(sortedArr[i])) 
                {
                    rankingDict[sortedArr[i]] = rank;
                    rank++; 
                }
            }
            int[] rankedArr = arr.Select(num => rankingDict[num]).ToArray();
            Console.WriteLine(string.Join(", ", rankedArr));
        }
        public static int Majority(int[] nums)
        {
            int n = nums.Length;

            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!frequencyDict.ContainsKey(nums[i]))
                {
                    frequencyDict[nums[i]] = 1;
                    
                }
                else
                {
                    frequencyDict[nums[i]]++;
                }
            }
            foreach (var pair in frequencyDict)
            {
                if (pair.Value > n/2)
                {
                    int majorityElement = pair.Value;
                    return pair.Key;
                }
            }
            return 0;
        }
    }
}
