namespace ExtraAssignments_week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            Console.WriteLine(FindNumber(new int[] {2,2,1}));
            Console.WriteLine(FindNumber(new int[] { 4, 1, 2, 1, 2 }));
            Console.WriteLine(FindNumber(new int[] { 1 }));

            Console.WriteLine(" ---- Problem 2 ---- ");



            Console.ReadKey();
        }
        static int FindNumber(int[] nums)
        {                      
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    set.Remove(num);        
                }
                else
                {
                    set.Add(num);
                }
            }
            return set.First();            
        }
    }
}
