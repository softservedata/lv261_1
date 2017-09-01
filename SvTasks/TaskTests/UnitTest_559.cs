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
        public void GetMersonNumber_100in_3_7_31out()
        {
            //arrange
            int expected1 = 3;
            int expected2 = 7;
            int expected3 = 31;

            //act
            List<int> res = tasks.GetMersonNumbers_559(100);
            int actual1 = res[0];
            int actual2 = res[1];
            int actual3 = res[2];

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void GetMersonNumber_0in_emptyListOut()
        {
            //arrange
            int expectedCount = 0;

            //act
            List<int> res = tasks.GetMersonNumbers_559(0);
            int actualCount = res.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
