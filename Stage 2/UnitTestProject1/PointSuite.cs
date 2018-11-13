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
            a.setCoordinates(1, 1);
            b.setCoordinates(3, 4);
           
            double r = Point.distanceBetween(a, b);
           
            Assert.AreEqual(3.6056, r, 0.0001);

        }
        [TestMethod]
        public void distanceToIntsTest()


        {
            Point src = new Point();
            src.setCoordinates(1, 1);
            
            double r = src.distanceTo(3, 4);
            Assert.AreEqual(3.6056, r, 0.0001);
        }
        [TestMethod]
        public void distanceToPointTest()

        {
            Point a = new Point(1,1);
            Point b = new Point(3,4);
            
            double r = b.distanceTo(a);

            Assert.AreEqual(3.6056, r, 0.0001);

        }
        [TestMethod]
        public void PointEqualsItself()
        {
            Point a = new Point();
            bool t = a.Equals(a);
            Assert.IsTrue(t);

            Assert.IsTrue(a.Equals(a));
        }
        [TestMethod]
        public void PointInstanceComparison()

        {
            Point a1, a2, b1, b2, b3, b4, b5, b6, b7, b8;
            a1 = new Point();
            a1.setCoordinates(10, 15);
            a1.setColor("red");
            a2 = new Point();
            a2.setCoordinates(10, 15);
            a2.setColor("red");
            b1 = new Point();
            b1.setCoordinates(0, 0);
            b1.setColor("green");
            b2 = new Point();
            b2.setCoordinates(10, 3);
            b2.setColor("green");
            b3 = new Point();

            b3.setCoordinates(1, 15);
            b3.setColor("green");
            b4 = new Point();
            b4.setCoordinates(5, 7);
            b4.setColor("red");
            b5 = new Point();
            b5.setCoordinates(10, 15);
            b5.setColor("green");
            b6 = new Point();

            b6.setCoordinates(10, 3);
            b6.setColor("red");
            b7 = new Point();
            b7.setCoordinates(2, 15);
            b7.setColor("red");
            Assert.IsTrue(a1.Equals(a2));
            Assert.IsTrue(a2.Equals(a1));
            Point [] arr = {b1,b2,b3,b4,b5,b6,b7 };
            int i= 0;
            while (i<arr.Length-1)
            {
                Assert.IsFalse(arr[i].Equals(a1));
                i++;
            }
            i = 0;
            while (i < arr.Length - 1)
            {
                Assert.IsFalse(arr[i].Equals(a2));
                i++;
            }
            i = 0;
            while (i < arr.Length - 1)
            {
                Assert.IsFalse(a1.Equals(arr[i]));
                i++;
            }
            i = 0;
            while (i < arr.Length - 1)
            {
                Assert.IsFalse(a2.Equals(arr[i]));
                i++;
            }

        }
        [TestMethod]
        public void PointNotEqualNull()
        {
            Point p = new Point();
            Assert.IsFalse(p.Equals(null));
        }
        [TestMethod]
        public void PointNotEqualOtherClass()
        {
            Point p = new Point();
            Assert.IsFalse(p.Equals("not point"));
        }
    }
}
