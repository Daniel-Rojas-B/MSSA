namespace Mod7ShellSort
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

                    while (j >= 0 && A[j] > temp) // Fix: j should be >= 0
                    {
                        A[j + gap] = A[j]; // Fix: Shift A[j] instead of assigning A[i]
                        j -= gap;
                    }
                    A[j + gap] = temp; // Final position for temp
                    i++;
                }
                gap /= 2;
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 3, 5, 8, 9, 6, 2 };
            ShellSort(A);
            foreach(int num in A)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");
        }
    }
}
