using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kode_project;

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
            double r= Metods.task4411(11.13);
            double a= Metods.task4411(-7919);
            double b= Metods.task4411(0);

            Assert.AreEqual(18.13, r, 0.001);
            Assert.AreEqual(-7912, a, 0.001);
            Assert.AreEqual(7, b, 0.001);
        }
        [TestMethod]
        public void Task2790test()
        {
            double a= Metods.task2790(6997);
            double b = Metods.task2790(31);
            double c = Metods.task2790(90);
            double d = Metods.task2790(0);
            double e = Metods.task2790(180);
            Assert.AreEqual(0.9205,a,0.001);
            Assert.AreEqual(0.8572, b, 0.001);
            Assert.AreEqual(0.0000, c, 0.001);
            Assert.AreEqual(1.0000, d, 0.001);
            Assert.AreEqual(1.0000, e, 0.001);
        }
        [TestMethod]
        public void Task3946test()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 1 };
            double r = Metods.task3946(arr);
            Assert.AreEqual(2.2, r, 0.001);
        }
        [TestMethod]
        public void Task4283test()
        {
            int k = 3;
            int[] arr = new int[] { 1, 2, 3, 4, 1,2 };
            double a = Metods.task4283(k,arr);
            Assert.AreEqual(1, a);

            k = 5;
            arr = new int[] { 1, 2, 3, 4, 1, 2,3,4,1,2,3 };
            a = Metods.task4283(k, arr);
            Assert.AreEqual(0, a);

            k = 2;
            arr = new int[] { 3,2,2,2,2,2 };
            a = Metods.task4283(k, arr);
            Assert.AreEqual(5, a);

            k = 1;
            arr = new int[] { 4,4,4,4,4,4 };
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
            expected1 = new double[] { -27, - 24,- 21, - 18, - 15, - 12 };
            CollectionAssert.AreEqual(expected1, data1);

            data1 = new double[] { 98, 76, 54 };
            Metods.task9774(11, data1);
            expected1 = new double[] { 1078, 836, 594 };
            CollectionAssert.AreEqual(expected1, data1);


        }
    }
}
