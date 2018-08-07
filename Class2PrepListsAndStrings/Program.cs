using System;
using System.Collections.Generic;
namespace Class2PrepListsAndStrings
{
    class Program
    {
        static string FiveLetters(List<string> aList)
        {
            string theString = "";
            foreach (string i in aList)
            {
                if (i.Length == 5)
                {
                    theString += " " + i;
                }
            }
            return theString;
        }

        static void Main(string[] args)
        {
            List<string> thisList = new List<string>(new string[] { "food", "fat", "alligator", "beast", "cyborg", "robin", "star", "raven", "batman", "qqqqq", "the" });
            Console.WriteLine(FiveLetters(thisList));
            Console.ReadLine();
        }
    }
}
