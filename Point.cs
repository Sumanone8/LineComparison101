using System;

namespace LineComparison101
{
    internal class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public double CalculateDistance(Point otherPoint)
        {
            double deltaX = otherPoint.GetX() - x;
            double deltaY = otherPoint.GetY() - y;
            return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Point otherPoint = (Point)obj;
            return x == otherPoint.GetX() && y == otherPoint.GetY();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }
    }
}