namespace Assignment12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Problem 1 ----");
            Console.WriteLine(Strings("abcc", "oweabc"));

        }
        public static bool Strings(string ransomNote, string magazine)
        {
            bool output = true;

            Dictionary<char, int> ransomNoteDict = new Dictionary<char, int>();
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (!ransomNoteDict.ContainsKey(ransomNote[i]))
                {
                    ransomNoteDict[ransomNote[i]] = 0;
                    ransomNoteDict[ransomNote[i]]++;
                }
                else
                {
                    ransomNoteDict[ransomNote[i]]++;
                }
            }
            Dictionary<char, int> magazineDict = new Dictionary<char, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                if (!magazineDict.ContainsKey(magazine[i]))
                {
                    magazineDict[magazine[i]] = 0;
                    magazineDict[magazine[i]]++;
                }
                else
                {
                    magazineDict[magazine[i]]++;
                }
            }
            foreach (var pair in ransomNoteDict)
            {
                char letter = pair.Key;
                int frequencyNeeded = pair.Value;

                if (!magazineDict.ContainsKey(letter) || magazineDict[letter] < frequencyNeeded)
                {
                    output = false;
                    break;
                }
            }


            return output;
        }
    }
}
