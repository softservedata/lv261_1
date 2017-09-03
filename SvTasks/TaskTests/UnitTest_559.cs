using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SvTasks;
using System.Collections.Generic;

namespace TaskTests
{
    [TestClass]
    public class UnitTest_559
    {
        Tasks tasks = new Tasks();

        [TestMethod]
        public void GetPrimeMersonNumber_100in_3_7_31out()
        {
            //arrange
            int expected1 = 3;
            int expected2 = 7;
            int expected3 = 31;

            //act
            List<int> res = tasks.GetPrimeMersonNumbers_559(100);
            int actual1 = res[0];
            int actual2 = res[1];
            int actual3 = res[2];

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void GetPrimeMersonNumber_IntMaxin_3_7_31out()
        {
            //arrange
            int expected1 = 3;
            int expected2 = 7;
            int expected3 = 31;
            int expected4 = 127;
            int expected5 = 8191;
            int expected6 = 131071;
            int expected7 = 524287;


            //act
            List<int> res = tasks.GetPrimeMersonNumbers_559(int.MaxValue);
            int actual1 = res[0];
            int actual2 = res[1];
            int actual3 = res[2];
            int actual4 = res[3];
            int actual5 = res[4];
            int actual6 = res[5];
            int actual7 = res[6];

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);
            Assert.AreEqual(expected6, actual6);
            Assert.AreEqual(expected7, actual7);


        }

        [TestMethod]
        public void GetPrimeMersonNumber_0in_emptyListOut()
        {
            //arrange
            int expectedCount = 0;

            //act
            List<int> res = tasks.GetPrimeMersonNumbers_559(0);
            int actualCount = res.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
