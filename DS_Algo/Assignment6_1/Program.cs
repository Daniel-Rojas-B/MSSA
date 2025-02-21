namespace Assignment6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            LList houseList = new LList();

            houseList.AddFirst(1, "123 abc", "Ranch");
            houseList.AddFirst(2, "456 def", "Colonial");
            houseList.AddFirst(3, "789 ghi", "Ranch");

            houseList.Display();
            Console.WriteLine("Please type the house id you are looking for: ");
            int houseId = int.Parse(Console.ReadLine());
            houseList.Search(houseId);

            Console.WriteLine(" ---- Problem 2 ---- ");

            int[] nums1 = { 0, 1, 0, 3, 12 }; 
            RearrangeZeroes(nums1); 
            Console.WriteLine(string.Join(", ", nums1));

            int[] nums2 = { 0 };
            RearrangeZeroes(nums2);
            Console.WriteLine(string.Join(", ", nums2));

            Console.ReadKey();

        }
        public static void RearrangeZeroes(int[] nums)
        {
            int reference = 0; 

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                   
                    int temp = nums[i];
                    nums[i] = nums[reference];
                    nums[reference] = temp;
                    reference++;
                }
            }
        }
    }
}
