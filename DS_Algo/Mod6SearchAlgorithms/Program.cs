namespace Mod6SearchAlgorithms
{
    internal class Program
    {
        static int LinearSearch(int[] array, int val)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                    return i;
            }
            return -1;
        }
        static int BinarySearch(int[] array, int val)
        {
            int left = 0;
            int right = array.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (val == array[mid])
                {
                    return mid;
                }
                else if (val < array[mid])
                {
                    right = mid - 1;
                }
                else if (val > array[mid])
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LinearSearch(new int[] { 1,2,3,4}, 4));
            Console.WriteLine(LinearSearch(new int[] { 12,34,56,78,90,120,160 }, 170));
        }
    }
}
