using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kode_project;

namespace UnitTestProject1
{
    [TestClass]
    public class PointSuite
    {
        [TestMethod]
        public void distanceBetweeenInts()
        {
            double r = Point.distanceBetween(1, 1, 3, 4);
            Assert.AreEqual(3.6056, r, 0.0001);
            double r1 = Point.distanceBetween(-2, 4, 8, -10);
            Assert.AreEqual(17.2046, r1, 0.0001);
            double r2 = Point.distanceBetween(0, 0, -5, -7);
            Assert.AreEqual(8.6023, r2, 0.0001);
            double r3 = Point.distanceBetween(0, 0, 0, 0);
            Assert.AreEqual(0, r3, 0.0001);
            double r4 = Point.distanceBetween(-1, -3, 2, 9);
            Assert.AreEqual(12.3693, r4, 0.0001);
        }
        [TestMethod]
        public void distanceBetweeenObjects()

        {
            Point a = new Point();
            Point b = new Point();
            a.x = 1;
            a.y = 1;
            b.x = 3;
            b.y = 4;
            double r = Point.distanceBetween(a, b);
           
            Assert.AreEqual(3.6056, r, 0.0001);

        }
        [TestMethod]
        public void distanceToIntsTest()


        {
            Point src = new Point();
            src.x = 1;
            src.y = 1;
            double r = src.distanceTo(3, 4);
            Assert.AreEqual(3.6056, r, 0.0001);
        }
        [TestMethod]
        public void distanceToPointTest()

        {
            Point a = new Point();
            Point b = new Point();
            a.x = 1;
            a.y = 1;
            b.x = 3;
            b.y = 4;
            double r = b.distanceTo(a);

            Assert.AreEqual(3.6056, r, 0.0001);

        }
    }
}
