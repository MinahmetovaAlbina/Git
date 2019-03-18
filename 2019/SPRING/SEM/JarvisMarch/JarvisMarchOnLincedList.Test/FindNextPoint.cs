using NUnit.Framework;
using JarvisMarch;
using System.Collections.Generic;

namespace Tests
{
    public class TestsFindNextPoint
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TwoPoint()
        {
            var points = new LinkedList<Point>(new Point[] { new Point(1, 1), new Point(2, 2) });
            Assert.AreEqual(new Point(1, 1), FindNextPoint(points, new Point(2, 2), new Point(1, 1)));
        }

        [Test]
        public void PointsOnOne()
        {
            var points = new LinkedList<Point>
                (new Point[] { new Point(1, 1), new Point(4, 4), new Point(3, 3), new Point(2, 2), new Point(5, 5) });
            Assert.AreEqual(new Point(3, 3), FindNextPoint(points, new Point(2, 2), new Point(1, 1)));
        }

        [Test]
        public void Points()
        {
            var points = new LinkedList<Point>(new Point[]
            { new Point(1, 5), new Point(9, 2), new Point(2, 2), new Point(5, 7), new Point(6, 4), new Point(8, 7) });
            Assert.AreEqual(new Point(5, 7), FindNextPoint(points, new Point(8, 7), new Point(9, 2)));
        }

        private Point FindNextPoint(LinkedList<Point> points, Point a, Point b)
        {
            var m = new JarvisMarch.JarvisMarch();
            var t = 0;
            return m.FindNextPoint(points, a, b, ref t);
        }
    }
}