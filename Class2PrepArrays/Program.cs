using System;

namespace Class2PrepArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 5, 3, 7, 1, 45, 3, 56, 3, 4 };
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
