using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SvTasks;
using System.Collections.Generic;

namespace TaskTests
{
    [TestClass]
    public class UnitTest_226
    {
        Tasks tasks = new Tasks();

        [TestMethod]
        public void GetAllCommonDividers_6and9_18and36retuned()
        {
            //arrange
            int n = 6;
            int m = 9;
            double firstItemExpected = 18;
            double secondItemExpected = 36;

            //act
            List<double> actual = tasks.GetAllCommonDividers_226(n, m);
            double firstItemActual = actual[0];
            double secondItemActual = actual[1];

            //assert
            Assert.AreEqual(firstItemExpected, firstItemActual);
            Assert.AreEqual(secondItemExpected, secondItemActual);
        }

        [TestMethod]
        public void GetAllCommonDividers_9and6_18and36retuned()
        {
            //arrange
            int n = 9;
            int m = 6;
            double firstItemExpected = 18;
            double secondItemExpected = 36;

            //act
            List<double> actual = tasks.GetAllCommonDividers_226(n, m);
            double firstItemActual = actual[0];
            double secondItemActual = actual[1];

            //assert
            Assert.AreEqual(firstItemExpected, firstItemActual);
            Assert.AreEqual(secondItemExpected, secondItemActual);
        }

        [TestMethod]
        public void GetAllCommonDividers_0and0_emptyListRetuned()
        {
            //arrange
            int n = 0;
            int m = 0;
            int listCountExpected = 0;

            //act
            List<double> commonDividers = tasks.GetAllCommonDividers_226(n, m);
            int listCountActual = commonDividers.Count;

            //assert
            Assert.AreEqual(listCountExpected, listCountActual);
        }
    }
}
