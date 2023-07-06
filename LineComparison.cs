using System;

namespace LineComparison101
{
    internal class LineComparison
    {
        public void CalculateLineLength()
        {
            Console.WriteLine("Welcome to the Line Length Calculator!");

            // Input the coordinates of the endpoints
            Console.WriteLine("Enter the coordinates for Line 1:");
            double x1Line1 = ReadCoordinate("x1");
            double y1Line1 = ReadCoordinate("y1");
            double x2Line1 = ReadCoordinate("x2");
            double y2Line1 = ReadCoordinate("y2");

            // Input the coordinates of the endpoints for Line 2
            Console.WriteLine("Enter the coordinates for Line 2:");
            double x1Line2 = ReadCoordinate("x1");
            double y1Line2 = ReadCoordinate("y1");
            double x2Line2 = ReadCoordinate("x2");
            double y2Line2 = ReadCoordinate("y2");

            // Calculate the length of the line using the distance formula
            double deltaxLine1 = x2Line1 - x1Line1;
            double deltayLine1 = y2Line1 - y1Line1;
            double length1 = Math.Sqrt((deltaxLine1 * deltaxLine1) + (deltayLine1 * deltayLine1));

            // Calculate the length of the line using the distance formula
            double deltaxLine2 = x2Line2 - x1Line2;
            double deltayLine2 = y2Line2 - y1Line2;
            double length2 = Math.Sqrt((deltaxLine2 * deltaxLine2) + (deltayLine2 * deltayLine2));

            Console.WriteLine("The length of the first line is: " + length1);
            Console.WriteLine("The length of the second line is: " + length2);

            if (length1 == length2)
            {
                Console.WriteLine("Line 1 is equal to Line 2");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is less than Line 2");
            }
        }
                static double ReadCoordinate(string coordinateName)
                {
                    Console.Write($"Enter the {coordinateName} coordinate: ");
                    return Convert.ToDouble(Console.ReadLine());
                }
    }
}