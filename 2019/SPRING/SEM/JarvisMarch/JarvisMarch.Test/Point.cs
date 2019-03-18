using NUnit.Framework;
using JarvisMarch;
using System;

namespace Tests
{
    public class TestsPoint
    {
        [Test]
        public void FindDistance()
        {
            var point = new Point(1, 1);
            Assert.AreEqual(Math.Sqrt(18), point.Distance(new Point(4, 4)));
        }

        [Test]
        public void AcuteAngle()
        {
            var point = new Point(1, 1);
            Assert.AreEqual(1 / Math.Sqrt(2), point.Cos(new Point(-1, 1), new Point(-1, 3)));
        }

        [Test]
        public void ObtuseAngle()
        {
            var point = new Point(1, 1);
            Assert.AreEqual(-1 / Math.Sqrt(2), point.Cos(new Point(-1, 1), new Point(3, 3)));
        }

        [Test]
        public void RightAngle()
        {
            var point = new Point(1, 1);
            Assert.AreEqual(0, point.Cos(new Point(-3, 1), new Point(1, 2)));
        }
    }
}