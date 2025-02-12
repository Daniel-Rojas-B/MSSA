namespace Mod1HappyNumber
{
    internal class Program
    {        
        static bool Sumofdigitssquare(int n)
        {
            HashSet<int> set = new HashSet<int>();
            while (n > 0)
            {
                int sum = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    n = n / 10;
                    sum = sum + digit * digit;
                }
                if (set.Contains(sum))
                {
                    return false; // means its in a loop
                }
                else
                {
                    set.Add(sum);
                }
                if (sum == 1)
                {
                    return true;
                }
                n = sum;
            }
            return false;
        }
        static bool UglyNumber(int n)
        {
            if (n > 6)
            {
                return false;
            }
            if (n % 5 == 0 || n % 3 == 0 || n % 2 == 0 || n % 1 == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sumofdigitssquare(19));
            Console.WriteLine(UglyNumber(6));
            Console.WriteLine(UglyNumber(1));
            Console.WriteLine(UglyNumber(14));

            Console.ReadKey();
        }
    }
}
