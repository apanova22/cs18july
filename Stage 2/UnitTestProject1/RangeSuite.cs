using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kode_project;

namespace UnitTestProject1
{
    class RangeSuite
    {
        [TestClass]
        public class HasIntersectionIntsTest
        {
            [TestMethod]
            public void HasIntersection()
            {
                bool o = Range.HasIntersection(2, 3, 5, 7);
                Assert.IsFalse(o);
                bool o1 = Range.HasIntersection(11, 17, 13, 19);
                Assert.IsTrue(o1);
                bool o2 = Range.HasIntersection(23, 37, 29, 31);
                Assert.IsTrue(o2);
                bool o3 = Range.HasIntersection(43, 53, 41, 47);
                Assert.IsTrue(o3);
                bool o4 = Range.HasIntersection(5, 15, 0, 30);
                Assert.IsTrue(o4);
                bool o5 = Range.HasIntersection(67, 71, 59, 61);
                Assert.IsFalse(o5);
            }
                [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void HasIntersection1()
            {
               bool o6 = Range.HasIntersection(79, 73, 83, 89);
              
            }
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void HasIntersection2()
            {
                 bool o7 = Range.HasIntersection(97, 101, 107, 103);

            }
            [TestMethod]
            public void HasIntersection3()
            {
                Range left = new Range();
                Range right = new Range();
                left.from = 2;
                left.to = 3;
                right.from = 5;
                right.to = 7;
                bool r = Range.HasIntersection(left, right);
                Assert.IsFalse(r);
            }

            [TestMethod]
            public void HasIntersection4()
            {
                Range left = new Range();
                Range right = new Range();
                left.from = 2;
                left.to = 3;
                right.from = 5;
                right.to = 7;
                bool r = left.Intersects(5,7);
                Assert.IsFalse(r);
            }
            [TestMethod]
            public void HasIntersection5()
            {
                Range left = new Range();
                Range right = new Range();
                left.from = 2;
                left.to = 3;
                right.from = 5;
                right.to = 7;
                bool r = left.Intersects(right);
                Assert.IsFalse(r);
            }
        }
        }
    }

