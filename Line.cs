using System;

namespace LineComparison101
{
    internal class Line
    {
        private Point point1;
        private Point point2;

        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public double CalculateLength()
        {
            return point1.CalculateDistance(point2);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Line otherLine = (Line)obj;
            return point1.Equals(otherLine.point1) && point2.Equals(otherLine.point2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(point1, point2);
        }
    }
}
