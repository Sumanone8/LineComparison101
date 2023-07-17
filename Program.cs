using System;

namespace LineComparison101
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello Fellow learners, Welcome to Line Comparison Computation Program");

            Point point1Line1 = ReadPoint("Line 1, Point 1");
            Point point2Line1 = ReadPoint("Line 1, Point 2");
            Line line1 = new Line(point1Line1, point2Line1);

            Point point1Line2 = ReadPoint("Line 2, Point 1");
            Point point2Line2 = ReadPoint("Line 2, Point 2");
            Line line2 = new Line(point1Line2, point2Line2);

            double length1 = line1.CalculateLength();
            double length2 = line2.CalculateLength();

            Console.WriteLine("The length of the first line is: " + length1);
            Console.WriteLine("The length of the second line is: " + length2);

            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("Line 1 is equal to Line 2");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is less than Line 2");
            }
        }

        static Point ReadPoint(string pointName)
        {
            Console.Write($"Enter the coordinates for {pointName}:\n");
            double x = ReadCoordinate("x");
            double y = ReadCoordinate("y");
            return new Point(x, y);
        }

        static double ReadCoordinate(string coordinateName)
        {
            double coordinate;
            while (true)
            {
                Console.Write($"Enter the {coordinateName} coordinate: ");
                if (double.TryParse(Console.ReadLine(), out coordinate))
                {
                    return coordinate;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric coordinate.");
                }
            }
        }
    }
}