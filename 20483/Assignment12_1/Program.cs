using System.Text;

namespace Assignment12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Problem 1 ----");
            Console.WriteLine(Strings("a", "b"));
            Console.WriteLine(Strings("aa", "ab"));
            Console.WriteLine(Strings("aa", "aab"));

            Console.WriteLine("---- Problem 2 ----");
            ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
            Console.WriteLine(SinglyLinkedListPalindrome(head1));
            ListNode head2 = new ListNode(1, new ListNode(2));
            Console.WriteLine(SinglyLinkedListPalindrome(head2));

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
        public static bool SinglyLinkedListPalindrome(ListNode head)
        {
            StringBuilder sb = new StringBuilder();

            while(head is not null)
            {
                sb.Append(head.Val);
                head = head.Next;
            }

            String s = sb.ToString();

            return s.Reverse().SequenceEqual(s);
        }
    }
}
