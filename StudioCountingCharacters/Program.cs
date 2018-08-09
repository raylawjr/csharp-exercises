using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StudioCountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, type something out and I will tell you how many times you used each letter!");
            Console.WriteLine("You can type characters other than letters, but I'll only count the letters!");
            String theString = Console.ReadLine();
            String fixedString = Regex.Replace(theString, "[^a-zA-Z]", "");
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach(char x in fixedString.ToLower()){
                if (charCount.ContainsKey(x) == false)
                {
                    charCount.Add(x, 1);
                }
                else
                {
                    charCount[x] += 1;
                }
            }
            foreach (KeyValuePair<char, int> character in charCount) {
                StringBuilder sb = new StringBuilder();
                sb.Append(character.Key);
                sb.Append(": " + character.Value);
                Console.WriteLine(sb);
            }
            Console.ReadLine();
        }
    }
}
