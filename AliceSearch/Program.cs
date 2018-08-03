using System;

namespace AliceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("I can tell you if your input is contained in my secret string.  What is your input?");
            string s2 = Console.ReadLine();
            if (s1.ToLower().Contains(s2.ToLower()))
            {
                Console.WriteLine("My secret string contains your input!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No, my secret string does not contain your input!");
                Console.ReadLine();
            }
        }
    }
}
