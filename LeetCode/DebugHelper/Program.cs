namespace DebugHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Debugging ----");
            int[] nums = new int[] {1,2,3};
            Console.WriteLine(Subsets(nums));
        }
        public static IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            var subset = new List<int>();

            void Backtrack(int start)
            {
                result.Add(new List<int>(subset)); // Add a copy of current subset

                for (int i = start; i < nums.Length; i++)
                {
                    subset.Add(nums[i]);          // Choose
                    Backtrack(i + 1);             // Explore
                    subset.RemoveAt(subset.Count - 1); // Un-choose (backtrack)
                }
            }

            Backtrack(0);
            return result;
        }
    }
}
