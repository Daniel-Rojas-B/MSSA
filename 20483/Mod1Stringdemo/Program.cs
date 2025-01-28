using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Stringdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;// stack, value 
            string s;// heap , reference

            // strings are a sequence of characters enclosed in a double quote " "
            // they are immutable, when we use + operator with strings, it creates new memory locations 
            //with original + new data and the variable points to this new address location
            // the more + operations. more such strings are created

            string address = string.Empty;
            address = "45";
            address = address + " miller street"; // append

            // better 
            StringBuilder sb = new StringBuilder();
            sb.Append("45");
            sb.Append(" miller street");


            string s1 = "  amazing  ";
            Console.WriteLine(s1 + " after trimming :" + s1.Trim());

            string header = "* A Short Play. *";
            var newHeader = header.Trim(new char[] { ' ', '*', '.', ',' });
            Console.WriteLine(newHeader);
            Console.WriteLine(newHeader.Replace(' ', '-'));
            Console.WriteLine(newHeader.Remove(0, 1));

            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
            string vowelString = new string(vowels);
            foreach (char vowel in vowelString)
            {
            }
            string s2 = "Wake up early. Get to work";
            string[] words = s2.Split(new char[] { ' ', ',', '.' });
            foreach (string word in words)
            {
                if (word != string.Empty)
                    Console.WriteLine(word);
            }
            var s3 = s2.Substring(0, 5);
            Console.WriteLine(s3);

            Console.WriteLine("Enter a string to check for palindrome");
            var s4 = Console.ReadLine();
            var s5 = new string(s4.Reverse().ToArray());
            if(s4==s5)
            {
                Console.WriteLine("it is a palindrome");
            }
            else
            {
                Console.WriteLine("it is not a palindrome");
            }

            Console.ReadKey();
        }
    }
}
