namespace ExtraAssignments_week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            Console.WriteLine(Contains3(7201432));
            Console.WriteLine(Contains3(87501));

            Console.ReadKey();
        }
        public static bool Contains3(int number)
        {          
            while (number > 0)
            {
                if (number % 10 == 3)
                {
                    return true;
                }
                number = number / 10;
            }
            return false;
        }
    }
}
