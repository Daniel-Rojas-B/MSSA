namespace Week5_groupchallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(RobHouses(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(RobHouses(new int[] { 4,1,1,4 }));
        }
        static int RobHouses(int[] nums)
        {
            if (nums.Length == 1) return nums[0]; // Only one house to rob

            int prev1 = nums[0]; // Maximum money robbed up to house 0
            int prev2 = Math.Max(nums[0], nums[1]); // Maximum money robbed up to house 1

            for (int i = 2; i < nums.Length; ++i)
            {
                int current = Math.Max(prev1 + nums[i], prev2);  // Rob this house or skip it
                prev1 = prev2;  // Update prev1 to the value of prev2
                prev2 = current;  // Update prev2 to the new current value
            }
            return prev2;  // Maximum money robbed
        }

        //jay solution -------------------------------------------------------------------------------------------------------------------------

        //if (nums == null || nums.Length == 0)
        //    return 0;

        //if (nums.Length == 1)
        //    return nums[0];

        //if (nums.Length == 2)
        //    return Math.Max(nums[0], nums[1]);

        //int[] house = new int[nums.Length];
        //house[0] = nums[0];
        //house[1] = Math.Max(nums[0], nums[1]);

        //for (int i = 2; i < nums.Length; i++) //avoid adjacent house
        //{
        //    house[i] = Math.Max(house[i - 1], house[i - 2] + nums[i]);
        //}

        //return house[nums.Length - 1];
    }
 }

    
    

