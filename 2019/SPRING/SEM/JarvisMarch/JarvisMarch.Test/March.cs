using NUnit.Framework;
using JarvisMarch;
using System.Collections.Generic;

namespace Tests
{
    public class TestsMarch
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OnePoint()
        {
            var points = new Point[] { new Point(1, 1) };
            var hull = March(points);
            Assert.AreEqual(points.Length, hull.Count);
            for (var i = 0; i < points.Length; i++)
                Assert.AreEqual(points[i], hull[i]);
        }

        [Test]
        public void TwoPoint()
        {
            var points = new Point[] { new Point(1, 1), new Point(2, 2) };
            var hull = March(points);
            Assert.AreEqual(points.Length, hull.Count);
            for (var i = 0; i < points.Length; i++)
                Assert.AreEqual(points[i], hull[i]);
        }

        [Test]
        public void PointsOnOne()
        {
            var points = new Point[] { new Point(1, 1), new Point(3, 3), new Point(2, 2), new Point(4, 4), new Point(5, 5) };
            var expHull = new List<Point> { new Point(1, 1), new Point(2, 2), new Point(3, 3), new Point(4, 4), new Point(5, 5) };
            var hull = March(points);
            Assert.AreEqual(expHull.Count, hull.Count);
            for (var i = 0; i < hull.Count; i++)
                Assert.AreEqual(hull[i], expHull[i]);
        }

        [Test]
        public void Points()
        {
            var points = new Point[]
            { new Point(1, 5), new Point(9, 2), new Point(2, 2), new Point(5, 7), new Point(6, 4), new Point(8, 7) };
            var expHull = new List<Point>
            { new Point(2, 2), new Point(9, 2), new Point(8, 7), new Point(5, 7), new Point(1, 5) };
            var hull = March(points);
            Assert.AreEqual(expHull.Count, hull.Count);
            for (var i = 0; i < hull.Count; i++)
                Assert.AreEqual(hull[i], expHull[i]);
        }

        private List<Point> March(Point[] points)
        {
            var m = new JarvisMarch.JarvisMarch();
            var t = 0;
            return m.March(points, ref t);
        }
    }
}