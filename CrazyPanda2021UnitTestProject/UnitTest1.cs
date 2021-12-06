using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CrazyPanda2021;
using System.Collections.Generic;

namespace CrazyPanda2021
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CrazyPanda2021Functions func = new CrazyPanda2021Functions();
            List<uint> list = new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 };
            ulong sum = 11;
            int start;
            int end;
            func.FindElementsForSum(list, sum,  out start,  out end);
            Assert.IsTrue(start == 5 && end == 7);

        }
        [TestMethod]
        public void TestMethod2()
        {
            CrazyPanda2021Functions func = new CrazyPanda2021Functions();
            List<uint> list = new List<uint> { 4, 5, 6, 7 };
            ulong sum = 18;
            int start;
            int end;
            func.FindElementsForSum(list, sum,  out start,  out end);
            Assert.IsTrue(start == 1 && end == 4);

        }

        [TestMethod]
        public void TestMethod3()
        {
            CrazyPanda2021Functions func = new CrazyPanda2021Functions();
            List<uint> list = new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 };
            ulong sum = 88;
            int start;
            int end;
            func.FindElementsForSum(list, sum,  out start,  out end);
            Assert.IsTrue(start == 0 && end == 0);

        }

        [TestMethod]
        public void TestMethod4()
        {
            CrazyPanda2021Functions func = new CrazyPanda2021Functions();
            List<uint> list = new List<uint> { 0};
            Random rnd = new Random();
            uint x;
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 1000000; i++)
            {
                x = (uint)rnd.Next(1, 100);
                list.Add(x);
            }
            ulong sum = 868684;
            int start;
            int end;
            func.FindElementsForSum(list, sum,  out start,  out end);
            Assert.IsNotNull(start);
            Assert.IsNotNull(end);

        }
    }
}
