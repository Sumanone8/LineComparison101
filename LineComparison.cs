using System;

namespace LineComparison101
{
    internal class LineComparison
    {
        public void CalculateLineLength()
        {
            Console.WriteLine("Welcome to the Line Length Calculator!");

            // Input the coordinates of the endpoints
            Console.Write("Enter the x-coordinate of the first endpoint: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the y-coordinate of the first endpoint: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the x-coordinate of the second endpoint: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the y-coordinate of the second endpoint: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Calculate the length of the line using the distance formula
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double length = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
            Console.WriteLine("The length of the line is: " + length);
        }
    }
}