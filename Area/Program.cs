using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string radiusstr;
            double radiusdbl;
            double area;
            Console.WriteLine("Hello, I will find the area of a circle for you. Please enter a radius (using digits).  Your radius must be a positive number!");
            radiusstr = Console.ReadLine();
            bool radiuscheck = double.TryParse(radiusstr, out radiusdbl);
            do
            {
                Console.WriteLine("You didn't enter a valid radius!");
                Console.ReadLine();
                Console.WriteLine("Please enter a radius (using digits).");
                radiusstr = Console.ReadLine();
                radiuscheck = double.TryParse(radiusstr, out radiusdbl);
            } while ((radiuscheck == false) || (radiusdbl <= 0));
                area = 3.14 * (radiusdbl * radiusdbl);
                Console.WriteLine("The area of a circle with radius {0} is {1}.", radiusdbl, area);
                Console.ReadLine();
        }
    }
}
