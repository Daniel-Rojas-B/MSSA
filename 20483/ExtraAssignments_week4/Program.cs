using System.Security.AccessControl;

namespace ExtraAssignments_week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            Console.WriteLine(Contains3(7201432));
            Console.WriteLine(Contains3(87501));

            Console.WriteLine(" ---- Problem 2 ---- ");
            Console.WriteLine(DivisibleBy2Or3(15, 30));
            Console.WriteLine(DivisibleBy2Or3(2, 90));
            Console.WriteLine(DivisibleBy2Or3(7, 12));

            Console.WriteLine(" ---- Problem 3 ---- ");
            Console.WriteLine(ReverseString(['h', 'e', 'l', 'l', 'o']));
            Console.WriteLine(ReverseString(['H', 'a', 'n', 'n', 'a', 'h']));

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
        public static int DivisibleBy2Or3(int num1, int num2)
        {
            if ((num1 % 2 == 0 || num1 % 3 == 0) && (num2 % 2 == 0 || num2 % 3 == 0))
            {
                return num1 * num2;
            }
            else
            {
                return num1 + num2;
            }
        }
        public static char[] ReverseString(char[] s)
        {
            int start = 0;
            int end = s.Length - 1;

           

            while (start < end)
            {
                char temp = s[start];
                s[start] = s[end];
                s[end] = temp;

                start++;
                end--;
            }
            return s;
        }
    }
}
