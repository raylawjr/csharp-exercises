using System;
using System.Collections.Generic;

namespace Class2PrepLists
{
    class Program
    {
        static int EvenListSum(List<int> aList)
        {
            int theSum = 0;
            foreach (int i in aList)
            {
                if (i%2 == 0)
                {
                    theSum += i;
                }
            }
            return theSum;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(new int[] { 1, 2, 3, 4, 4, 2, 3, 4, 7, 22 });
            Console.WriteLine(EvenListSum(numbers));
            Console.ReadLine();
        }
    }
}
