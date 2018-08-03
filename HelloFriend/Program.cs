using System;

namespace HelloFriend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is  your name?");
            string UserName = Console.ReadLine();
            Console.WriteLine("Hello {0}", UserName);
            Console.ReadLine();
        }
    }
}
