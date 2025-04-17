namespace Assignment12_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Problem 1----");
            RemoveDuplicates("abbaca");
            RemoveDuplicates("azxxzy");
        }
        public static void RemoveDuplicates(string word)
        {
            for(int i  = 0; i < word.Length-1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    word = word.Remove(i,2);
                    i = -1;
                }
            }
            Console.WriteLine(word);
        }
    }
}
