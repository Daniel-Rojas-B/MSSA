namespace Week11_ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Problem 1 ----");
            int[] nums1 = new int[] { 2, 0, 2, 1, 1, 0 };
            Colors(nums1);
            int[] nums2 = new int[] { 2,0,1 };
            Colors(nums2);

            Console.WriteLine("---- Problem 2 ----");
            Balloons("nlaebolko");
            Balloons("loonbalxballpoon");
            Balloons("leetcode");

        }
        public static void Colors(int[] nums)
        {
            int low = 0;              
            int mid = 0;              
            int high = nums.Length - 1; 

            while (mid <= high)
            {
                if (nums[mid] == 0)   
                {                    
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;

                    low++;
                    mid++;
                }
                else if (nums[mid] == 1) 
                {
                    mid++;
                }
                else                    
                {                    
                    int temp = nums[mid];
                    nums[mid] = nums[high];
                    nums[high] = temp;

                    high--;
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
        public static void Balloons(string text)
        {
            char[] keys = { 'b', 'a', 'l', 'l', 'o', 'o', 'n' };
            Dictionary<char,int> balloonDict = new Dictionary<char,int>();

            foreach (char key in keys)
            {
                if (!balloonDict.ContainsKey(key))
                {
                    balloonDict[key] = 0;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if(balloonDict.ContainsKey(text[i]))
                {
                    balloonDict[text[i]]++;
                }
            }
            int numBalloons = Math.Min(balloonDict['b'], Math.Min(balloonDict['a'],
                            Math.Min(balloonDict['l'] / 2, Math.Min(balloonDict['o'] / 2, balloonDict['n']))));
            Console.WriteLine(numBalloons);
        }
    }
}
