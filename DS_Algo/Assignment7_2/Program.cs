using System.Text;

namespace Assignment7_2
{
    internal class Program
    {
        static void ShellSort(int[] A)
        {
            int gap = A.Length / 2;
            int i, j;

            while (gap > 0)
            {
                i = gap;
                while (i < A.Length)
                {
                    int temp = A[i];
                    j = i - gap;

                    while (j >= 0 && A[j] > temp) 
                    {
                        A[j + gap] = A[j]; 
                        j -= gap;
                    }
                    A[j + gap] = temp; 
                    i++;
                }
                gap /= 2;
            }
        }
        static void ReverseVowels(string s)
        {
            char[] charArray = s.ToCharArray();
            //Console.WriteLine(charArray);
            int start = 0;
            int end = s.Length - 1;
            string allVowels = "aeiouAEIOU";

            while (start < end)
            {
                while (start < end && !allVowels.Contains(charArray[start]))
                {
                    start++;
                }
                while (start < end && !allVowels.Contains(charArray[end]))
                {
                    end--;
                }
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;

                start++;
                end--;
            }
            Console.WriteLine(charArray);

        }
        static bool Anagram(string s, string t)
        {
            bool result = false;

            char[] s_word = s.ToCharArray();
            char[] t_word = t.ToCharArray();

            Array.Sort(s_word);
            Array.Sort(t_word);

            return s_word.SequenceEqual(t_word);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ---- ");
            Console.WriteLine("Enter array of numbers separated by spaces:");
            string numbers = Console.ReadLine();
            string[] numbersArray = numbers.Split(' ');
            int[] A = Array.ConvertAll(numbersArray, int.Parse);
            ShellSort(A);
            foreach (int num in A)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(" ---- Problem 2 ---- ");
            ReverseVowels("hello");
            ReverseVowels("avacado");
            ReverseVowels("intelligent");

            Console.WriteLine(" ---- Problem 3 ---- ");
            Console.WriteLine(Anagram("anagram", "nagaram"));
            Console.WriteLine(Anagram("rat", "car"));

            Console.ReadKey();
        }
    }
}
