using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kode_project;
using task1212;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task4411test()
        {
            //Чтобы пользоваться классом из другого проекта нужно
            //добавить ссылку на другой проект

            //добавить директиву Using в файле где будет использоваться класс х
            //добавить модификатор доступа "public" у класса х
           
           

            Assert.AreEqual(18.13, Metods.task4411(11.13), 0.001);
            Assert.AreEqual(-7912, Metods.task4411(-7919), 0.001);
            Assert.AreEqual(7, Metods.task4411(0), 0.001);
        }
        [TestMethod]
        public void Task2790test()
        {
            double a = Metods.task2790(6997);
            double b = Metods.task2790(31);
            double c = Metods.task2790(90);
            double d = Metods.task2790(0);
            double e = Metods.task2790(180);
            Assert.AreEqual(0.9205, a, 0.001);
            Assert.AreEqual(0.8572, b, 0.001);
            Assert.AreEqual(0.0000, c, 0.001);
            Assert.AreEqual(1.0000, d, 0.001);
            Assert.AreEqual(1.0000, e, 0.001);
        }
        [TestMethod]
        public void Task3946test()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 1 };
           
            Assert.AreEqual(2.2,  Metods.task3946(arr), 0.001);
        }
        [TestMethod]
        public void Task4283test()
        {
            int k = 3;
            int[] arr = new int[] { 1, 2, 3, 4, 1, 2 };
            double a = Metods.task4283(k, arr);
            Assert.AreEqual(1, a);

            k = 5;
            arr = new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3 };
            a = Metods.task4283(k, arr);
            Assert.AreEqual(0, a);

            k = 2;
            arr = new int[] { 3, 2, 2, 2, 2, 2 };
            a = Metods.task4283(k, arr);
            Assert.AreEqual(5, a);

            k = 1;
            arr = new int[] { 4, 4, 4, 4, 4, 4 };
            a = Metods.task4283(k, arr);
            Assert.AreEqual(0, a);
        }
        [TestMethod]
        public void Task9774()
        {

            double[] data1 = new double[] { 9, 8, 7, 6, 5, 4 };
            Metods.task9774(31, data1);
            double[] expected1 = new double[] { 279, 248, 217, 186, 155, 124 };
            CollectionAssert.AreEqual(expected1, data1);

            data1 = new double[] { 9, 8, 7, 6, 5, 4 };
            Metods.task9774(-3, data1);
            expected1 = new double[] { -27, -24, -21, -18, -15, -12 };
            CollectionAssert.AreEqual(expected1, data1);

            data1 = new double[] { 98, 76, 54 };
            Metods.task9774(11, data1);
            expected1 = new double[] { 1078, 836, 594 };
            CollectionAssert.AreEqual(expected1, data1);


        }
        [TestMethod]
        public void Task5662test()
        {
            string f = Metods.task5662(1, 2, 3);
            string v = Metods.task5662(11, 13, 19);
            string j = Metods.task5662(3, 17, 5);
            string d = Metods.task5662(1, 2, 1);
            string e = Metods.task5662(0, 7, 13);
            Assert.AreEqual("Вещественных корней уравнения 1x^2 + 2x + 3 = 0 нет", f);
            Assert.AreEqual("Вещественных корней уравнения 11x^2 + 13x + 19 = 0 нет", v);
            Assert.AreEqual("У уравнения 3x^2 + 17x + 5 = 0 два вещественных корня", j);
            Assert.AreEqual("У уравнения 1x^2 + 2x + 1 = 0 один корень", d);
            Assert.AreEqual("Данное уравнение не является квадратным", e);

        }

        [TestMethod]
        public void Task3669test()
        {
            double a = Metods.task3669(8, 13);
            double b = Metods.task3669(13, 8);
            double c = Metods.task3669(159, 161);
            double d = Metods.task3669(648, 648);
            double e = Metods.task3669(-2, 600);
            double h = Metods.task3669(35, 24);
            Assert.AreEqual(1235520, a, 0.001);
            Assert.AreEqual(1235520, b, 0.001);
            Assert.AreEqual(4095840, c, 0.001);
            Assert.AreEqual(648, d, 0.001);
            Assert.AreEqual(0, e, 0.001);
            Assert.AreEqual(399703747322880000, h, 0.001);
        }
        [TestMethod]
        public void Task4847test()
        {
            bool e = Metods.task4847(31, 59, 83);
            bool h = Metods.task4847(19, 19, 41);
            bool r = Metods.task4847(7, 11, 11);
            bool p = Metods.task4847(67, -67, 67);
            bool o = Metods.task4847(1, 1, 1);
            Assert.IsFalse(e);
            Assert.IsTrue(h);
            Assert.IsTrue(r);
            Assert.IsTrue(p);
            Assert.IsTrue(o);
        }
        [TestMethod]
        public void Task9020test()
        {
            double r1 = Metods.task9020(0);
            Assert.AreEqual(23.4307, r1, 0.0001);
            double r2 = Metods.task9020(-9);
            Assert.AreEqual(25.0998, r2, 0.0001);
            double r3 = Metods.task9020(61);
            Assert.AreEqual(0, r3, 0.0001);
            double r4 = Metods.task9020(60);
            Assert.AreEqual(3, r4, 0.0001);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9020assertionX()
        {
            Metods.task9020(62);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9020assertiona()
        {
            Metods.task9020(7573);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9020assertionz()
        {
            Metods.task9020(75);
        }
        [TestMethod]
        public void Task3943test()
        {
            double r1 = Metods.task3943(-5,81);
            double r2 = Metods.task3943(7507, 7499);
           
            Assert.AreEqual(-10.0000, r1, 0.0001);
            Assert.AreEqual(-435.7062, r2, 0.0001);

        }
        [TestMethod]
        public void Task7799test()
        {
            double p = Metods.task7799(5, 45);
            double l = Metods.task7799(7297, 30);

            Assert.AreEqual(34.671920, p, 0.0001);
            Assert.AreEqual(61972.336135, l, 0.0001);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task7799assertion1()
        {
            Metods.task7799(0,30);
        }
        [TestMethod]
        public void Task9354test()
        {
            double p = Metods.task9354(7,1,3);
            double p1 = Metods.task9354(7247, 7243,7229);
            double p2 = Metods.task9354(-11,-13,-17);
            Assert.AreEqual(-83.0000, p, 0.0001);
            Assert.AreEqual(-157093203.0000, p1, 0.0001);
            Assert.AreEqual(-579.0000, p2, 0.0001);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9354assertion1()
        {
            Metods.task9354(0,1,3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task9354assertion2()
        {
            Metods.task9354(0,1000,2000);
        }
        [TestMethod]
        public void Task5170test()
        {
            string p = Metods.task5170(6);
            string p1 = Metods.task5170(3219);
            string p2 = Metods.task5170(7);
            string p3 = Metods.task5170(2017);
            Assert.AreEqual("число не простое", p);
            Assert.AreEqual("число не простое", p1);
            Assert.AreEqual("число простое", p2);
            Assert.AreEqual("число простое", p3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Task5170assertion1()
        {
            Metods.task5170(-10);
        }
        [TestMethod]
        public void Task1212test()
        {
            int[] p;
            p=Program.task1212("0;0;10;15");
            
            int[] expected1 = new int[] {0,0,10,15 };
            CollectionAssert.AreEqual(expected1, p);
           
        }
        [TestMethod]
        public void Task6497test()
        {
            int[] p = new int[]{ 9, 8, 9, 1, 1 ,5, 1, 1};
            double[] a = Metods.task6497(p);
            double[] t = new double[] { 4.6250, 3.6250, 4.6250, 3.3750, 3.3750, 0.6250, 3.3750, 3.3750 };
            CollectionAssert.AreEqual(t, a);
        }
    }
}
