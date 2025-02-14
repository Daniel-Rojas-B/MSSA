namespace Assignment5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Problem 1----");
            Console.WriteLine(Flowerbed(new int[] { 1, 0, 0, 0, 1 }, 1));
            Console.WriteLine(Flowerbed(new int[] { 1, 0, 0, 0, 1 }, 2));

            Console.WriteLine("---- Problem 2----");
            Console.WriteLine(Stairs(1));
            Console.WriteLine(Stairs(2));
            Console.WriteLine(Stairs(3));
            Console.WriteLine(Stairs(4));
            Console.WriteLine(Stairs(5));
        }
        static bool Flowerbed(int[] spaces, int n)
        {
            // ex: [1,0,0,0,1] return true
            int leftFlowers = n;
            // evaluate edge case where starts with 0,0 so a flowerbed can be allocated
            if (spaces[0] == 0 && spaces[1] == 0)
            {
                spaces[0] = 1;
                leftFlowers--;
            }
            for (int i = 1; i < spaces.Length - 1; i++)
            {
                if (spaces[i - 1] == 0 && spaces[i + 1] == 0)
                {
                    spaces[i] = 1;
                    leftFlowers--;
                }
                if (leftFlowers==0)
                {
                    return true;
                }
            }
            return false; 
        }
        static int Stairs(int n)
        {

            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n <= 2) return n;

            int beforeLast = 1;
            int last = 2;

            for (int i = 3; i <= n; i++)
            {
                int position = beforeLast + last; // start == 3
                beforeLast = last;
                last = position;
            }

            return last;

        }
    }
}
