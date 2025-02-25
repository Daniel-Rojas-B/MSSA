namespace Week6_challenge
{
    internal class Program
    {
        static void RotateMatrix(int[][] matrix)
        {
            int n = matrix.Length;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {                    
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                Array.Reverse(matrix[i]);
            }
            foreach (var num in matrix)
            {
                Console.WriteLine(string.Join(" ", num));
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            RotateMatrix(new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } });
            RotateMatrix(new[] { new[] { 5,1,9,11 }, new[] { 2,4,8,10 }, new[] { 13,3,6,7 }, new[] { 15, 14, 12, 16 } });

        }
    }
}
