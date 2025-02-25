using System.Text;

namespace Assignment7_1
{
    internal class Program
    {
        static void SelectionGradesSort(int[] Grades)
        {
            int minPosition = 0;
            int temp = 0;
            for (int i = 0; i < Grades.Length-1; i++)
            {
                minPosition = i;
                for (int j = i+1; j < Grades.Length; j++)
                {
                    if (Grades[j] < Grades[minPosition])
                    {
                        minPosition = j;
                    }
                    // swap
                    if (minPosition != i)
                    {
                        temp = Grades[i];
                        Grades[i] = Grades[minPosition];
                        Grades[minPosition]= temp;
                    }
                }
            }
        }

        public static string MergeWords(string word1, string word2)
        {
            StringBuilder result = new StringBuilder();
            int i = 0, j = 0;
            while (i < word1.Length && j < word2.Length)
            {
                result.Append(word1[i]).Append(word2[j]);
                i++;
                j++;
            }

            while (i < word1.Length)
            {
                result.Append(word1[i]);
                i++;
            }

            while (j < word2.Length)
            {
                result.Append(word2[j]);
                j++;
            }

            return result.ToString();
        }
        static void Main(string[] args)
        {
            int[] Grades = { 70, 85, 69, 95, 90, 96, 71, 99, 84 };
            SelectionGradesSort(Grades);
            Console.WriteLine(" ---- Problem 1 ----");
            Console.WriteLine(" ---- Sorted Grades ----");
            foreach (int Grade in Grades)
            {
                Console.WriteLine(Grade);            }

            Console.WriteLine(" ---- Problem 2 ----");
            Console.WriteLine(MergeWords("abc", "pqr"));
            Console.WriteLine(MergeWords("ab", "pqrs"));

            Console.ReadKey();
        }
    }
}
