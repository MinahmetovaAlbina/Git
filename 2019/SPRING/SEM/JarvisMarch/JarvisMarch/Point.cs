using System;
using System.Collections.Generic;

namespace JarvisMarch
{
    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        //возвращает косинус угла между прямыми проведёнными из точек к данной точке
        public double Cos(Point point1, Point point2)
        {
            return ((point1.X - X) * (point2.X - X) + (point1.Y - Y) * (point2.Y - Y)) / (Distance(point1) * Distance(point2));
        }

        public double Distance(Point point)
        {
            return Math.Sqrt((X - point.X) * (X - point.X) + (Y - point.Y) * (Y - point.Y));
        }

        public override bool Equals(object obj)
        {
            var point = obj as Point;
            return point != null &&
                   X == point.X &&
                   Y == point.Y;
        }

        public static bool operator ==(Point point1, Point point2)
        {
            return EqualityComparer<Point>.Default.Equals(point1, point2);
        }

        public static bool operator !=(Point point1, Point point2)
        {
            return !(point1 == point2);
        }

        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}", X, Y);
        }
    }
}
