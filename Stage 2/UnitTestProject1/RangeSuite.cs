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
                Range left = new Range(2,3);
                Range right = new Range(5,7);
                
             
                Assert.IsFalse(Range.HasIntersection(left, right));
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void IntersectsIntWrongLeftTest()
            {
                Range left = new Range(4, 3);
                left.Intersects(2,3);
            }
            [TestMethod]
            public void HasIntersection4()
            {
                Range left = new Range(2,3);
                Range right = new Range(5,7);
                
              
                Assert.IsFalse( left.Intersects(5,7));
            }
            [TestMethod]
            public void HasIntersection5()
            {
                Range left = new Range(2,3);
                Range right = new Range(5,7);
                
                
                Assert.IsFalse(left.Intersects(right));
            }
            [TestMethod]
            public void In()
            {
                Range one = new Range(3, 5);
                one.Shift(7);
                Range one1 = new Range(10, 12);
                bool r=one.Equals(one1);
                Assert.AreEqual(true,r);

            }
            [TestMethod]
            public void In1()
            {
                Range one = new Range(31, 43);
                one.Shift(-6);
                Range one1 = new Range(25, 37);
                bool r = one.Equals(one1);
                Assert.AreEqual(true, r);

            }
            [TestMethod]
            public void In2()
            {
                Range one = new Range(10, 50);
                one.Squeeze(30);
                Range one1 = new Range(10, 20);
                bool r = one.Equals(one1);
                Assert.AreEqual(true, r);

            }
            
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void In3()
        { Range one = new Range(23, 51);
                 one.Squeeze(100);
                
                

            }
            [TestMethod]
            public void In4()
            {
                Range one = new Range(19, 29);
                one.Squeeze(-5);
                Range one1 = new Range(19, 34);
                bool r = one.Equals(one1);
                Assert.AreEqual(true, r);

            }
        }
        }
    }

