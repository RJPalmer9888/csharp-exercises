using System;

namespace MPG
{
    class Program
    {
        public static void Main(string[] args)
        {
            double miles;
            string input1;
            double gas;
            string input2;
            double mpg;

            Console.WriteLine("I will calculate your MPG");
            Console.WriteLine("How many miles have you driven?");
            input1 = Console.ReadLine();
            miles = double.Parse(input1);

            Console.WriteLine("How many gallons of gas have you used?");
            input2 = Console.ReadLine();
            gas = double.Parse(input2);

            mpg = (miles / gas);

            Console.WriteLine("Your car gets " + mpg + " miles per gallon.");
            Console.ReadLine();
        }
    }
}
