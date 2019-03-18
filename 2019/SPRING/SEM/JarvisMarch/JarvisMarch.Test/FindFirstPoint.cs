using NUnit.Framework;
using JarvisMarch;

namespace Tests
{
    public class TestsFindFirstPoint
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OnePoint()
        {
            var points = new Point[] { new Point(1, 1) };
            Assert.AreEqual(new Point(1, 1), FindFirstPoint( points));
        }

        [Test]
        public void TwoPoint()
        {
            var points = new Point[] { new Point(1, 1), new Point(2, 2) };
            Assert.AreEqual(new Point(1, 1), FindFirstPoint(points));
        }

        [Test]
        public void Points()
        {
            var points = new Point[] { new Point(1, 1), new Point(3, 3), new Point(2, 2), new Point(4, 4), new Point(5, 5) };
            Assert.AreEqual(new Point(1, 1), FindFirstPoint( points));
        }

        [Test]
        public void PointsWithTheSameY()
        {
            var points = new Point[] { new Point(1, 5), new Point(9, 2), new Point(2, 2) };
            Assert.AreEqual(new Point(2, 2), FindFirstPoint(points));
        }

        private Point FindFirstPoint(Point[] points)
        {
            var a = new JarvisMarch.JarvisMarch();
            var t = 0;
            return a.FindFirstPoint(points, ref t);
        }
    }
}