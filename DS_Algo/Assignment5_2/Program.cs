namespace Assignment5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- Problem 1 ----");
            Console.WriteLine(LastWordLength("Hello world"));
            Console.WriteLine(LastWordLength(" fly me to the moon "));

            Console.WriteLine(" ---- Problem 2 ----");
            NaturalNumbers(10);

            Console.WriteLine();

            Console.WriteLine(" ---- Problem 3 ----");
            NaturalNumbersReverse(10);
            Console.WriteLine();
            Console.WriteLine(" ---- Problem 4 ----");
            Console.WriteLine(IsPalindrome("RADAR"));
            Console.WriteLine(IsPalindrome("RADARA"));


            Console.ReadKey();
        }
        static int LastWordLength(string word)
        {
            int wordLength = 0;
            for (int i = word.Length-1; i >=0; i--)
            {
                if (word[i] != ' ')
                {
                    wordLength++;
                }
                else if (wordLength > 0)
                {
                    return wordLength; 
                }

            }
            return wordLength;

        }
        static void NaturalNumbers(int n)
        {
            if (n>0)
            {
                NaturalNumbers(n - 1);
                Console.Write(n + " ");
            }
        }
        static void NaturalNumbersReverse(int n)
        {
            if (n > 0)
            {
                Console.Write(n + " ");
                NaturalNumbersReverse(n - 1);
            }
        }
        static bool IsPalindrome(string word)
        {
            if (word.Length <=1)
                return true;
            if (word[0] != word[word.Length-1])
                return false;
            
            return IsPalindrome(word.Substring(1, word.Length - 2));


            //    if (word.Length <= 1)
            //        return true;

            //    if (word[0] != word[word.Length - 1])
            //        return false;

            //    return IsPalindrome(word.Substring(1, word.Length - 2));

        }
    }
}
