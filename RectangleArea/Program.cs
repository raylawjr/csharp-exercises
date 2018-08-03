using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I will find the area of a rectangle for you.  Please input the height of your rectangle. (Integers only please!)");
            string height = Console.ReadLine();
            int intheight;
            bool heightcheck = int.TryParse(height, out intheight);
            if (heightcheck == false) {
                Console.WriteLine("You didn't enter an integer!");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Now, please enter a length.  (Again, integers only please!)");
                string length = Console.ReadLine();
                int intlength;
                bool lengthcheck = int.TryParse(length, out intlength);
                if (lengthcheck == false)
                {
                    Console.WriteLine("You didn't enter an integer!");
                    Console.ReadLine();
                }
                else  {
                    int area = intheight * intlength;
                    Console.WriteLine("The area of your rectangle is {0}.", area);
                    Console.ReadLine();
                }
            }
        }
    }
}
