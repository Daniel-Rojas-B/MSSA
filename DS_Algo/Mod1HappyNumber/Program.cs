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
        static void Main(string[] args)
        {
            Console.WriteLine(Sumofdigitssquare(19));
            
            Console.ReadKey();
        }
    }
}
