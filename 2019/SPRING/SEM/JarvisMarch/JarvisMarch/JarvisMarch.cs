using System;
using System.Collections.Generic;
using System.Linq;

namespace JarvisMarch
{
    public class JarvisMarch
    {
        private HashSet<Point> hashset = new HashSet<Point>();
        
        public List<Point> March(IEnumerable<Point> points, ref int iterations)
        {
            var firstPoint = FindFirstPoint(points, ref iterations);
            var prevPoint = firstPoint;
            var point = firstPoint;
            if (points.Count() > 1) point = FindNextPoint(points, firstPoint, ref iterations);
            var hull = new List<Point> { firstPoint };

            while (point != firstPoint)
            {
                hull.Add(point);
                hashset.Add(point);
                var p = FindNextPoint(points, point, prevPoint, ref iterations);
                prevPoint = point;
                point = p;
            }
            return hull;
        }

        //самая левая из самых нижних точек
        public Point FindFirstPoint(IEnumerable<Point> points, ref int iterations)
        {
            if (points == null || points.Count() == 0) throw new InvalidOperationException();
            var firstPoint = points.First();
            foreach (var point in points)
            {
                if (point.Y < firstPoint.Y || point.Y == firstPoint.Y && point.X < firstPoint.X)
                    firstPoint = point;
                iterations++;
            }
            return firstPoint;
        }

        public Point FindNextPoint(IEnumerable<Point> points, Point point, Point prevPoint, ref int iterations)
        {
            var nextPoint = prevPoint;
            var cos = 2.0;
            foreach (var p in points)
            {
                //тк поиск ведётся только среди точек не добавленных в оболочку и самой первой точки
                if (!hashset.Contains(p))
                {
                    var newCos = point.Cos(prevPoint, p);
                    if (Math.Abs(cos - newCos) < 1e-5 && point.Distance(p) < point.Distance(nextPoint)
                        || cos - newCos >= 1e-5)
                    {
                        cos = newCos;
                        nextPoint = p;
                    }
                    iterations++;
                }
            }
            return nextPoint;
        }

        public Point FindNextPoint(IEnumerable<Point> points, Point point, ref int iterations)
        {
            return FindNextPoint(points, point, new Point(point.X - 1, point.Y), ref iterations);
        }
    }
}
