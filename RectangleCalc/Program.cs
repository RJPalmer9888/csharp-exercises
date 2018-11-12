using System;

namespace RectangleCalc
{
    class Program
    {
        public static void Main(string[] args)
        {
            double length;
            string input1;
            double height;
            string input2;
            double area;

            Console.WriteLine("I will calculate the area of a rectangle");
            Console.WriteLine("What's the length?");
            input1 = Console.ReadLine();
            length = double.Parse(input1);
            
            Console.WriteLine("What's the height?");
            input2 = Console.ReadLine();
            height = double.Parse(input2);

            area = (length * height);

            Console.WriteLine("The area of the rectangle is " + area + " units.");
            Console.ReadLine();
        }
    }
}
