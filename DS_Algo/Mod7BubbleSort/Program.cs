namespace Mod7BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort(new int[] { 100, 2, 43, 22, 41 });
        }
        static void BubbleSort(int[] A)
        {
            int temp = 0;
            for (int pass = A.Length - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
        }
    }
}
