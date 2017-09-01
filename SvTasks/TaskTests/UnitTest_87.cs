using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SvTasks;

namespace TaskTests
{
    [TestClass]
    public class UnitTest_87
    {
        Tasks tasks = new Tasks();

        [TestMethod]
        public void GetSum_n12345_m3_12retuned()
        {
            //arrange
            int n = 12345;
            byte m = 3;
            int expected = 12;

            //act
            int actual = tasks.GetSum_87(n, m);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSum_n12_m3_minus1retuned()
        {
            //arrange
            int n = 12;
            byte m = 3;
            int expected = -1;

            //act
            int actual = tasks.GetSum_87(n, m);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSum_n0_m0_minus1retuned()
        {
            //arrange
            int n = 0;
            byte m = 0;
            int expected = -1;

            //act
            int actual = tasks.GetSum_87(n, m);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
