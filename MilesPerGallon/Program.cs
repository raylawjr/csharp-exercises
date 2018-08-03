using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I can calculate your car's fuel efficiency.  How many miles did you drive? (Please enter either a whole number or decimal)");
            string miles = Console.ReadLine();
            float floatmiles;
            bool milescheck = float.TryParse(miles, out floatmiles);
            if (milescheck == false)
            {
                Console.WriteLine("I don't think you entered a whole number or decimal!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            Console.WriteLine("Now, how many gallons of fuel did your car consume (Please enter either a whole number or decimal)");
            string gallons = Console.ReadLine();
            float floatgallons;
            bool gallonscheck = float.TryParse(gallons, out floatgallons);
            if (gallonscheck == false)
            {
                Console.WriteLine("I don't think you entered a whole number or decimal!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            float result = floatmiles / floatgallons;
            Console.WriteLine("Your car's fuel efficiency for that trip was {0} miles-per-gallon.", result);
            Console.ReadLine();
        }
    }
}
