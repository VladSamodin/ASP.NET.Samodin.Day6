using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2.RefactoringGCD.Tests
{
    [TestClass]
    public class AlgorithmsTests
    {
        #region GCD Euclidean algorithm tests
        [TestMethod]
        public void GCDEuclidean_2PositiveParams30And18_6()
        {
            const int a = 30;
            const int b = 18;
            const int expected = 6;
            TimeSpan runTime;
            int actual = Algorithms.GCDEuclidean(out runTime, a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GCDEuclidean_2NegativeParamsMinus30AndMinus18_6()
        {
            const int a = -30;
            const int b = -18;
            const int expected = 6;
            TimeSpan runTime;
            int actual = Algorithms.GCDEuclidean(out runTime, a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GCDEuclidean_3Params11310And5382And14586_78()
        {
            const int a = 11310;
            const int b = 5382;
            const int c = 14586;
            const int expected = 78;
            TimeSpan runTime;
            int actual = Algorithms.GCDEuclidean(out runTime, a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GCDEuclidean_4Params38688And5382And14586And11310_78()
        {
            const int a = 38688;
            const int b = 5382;
            const int c = 14586;
            const int d = 11310;
            const int expected = 78;
            TimeSpan runTime;
            int actual = Algorithms.GCDEuclidean(out runTime, a, b, c, d);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region GCD Binary algorithm tests
        [TestMethod]
        public void GCDBinary_2PositiveParams30And18_6()
        {
            const int a = 30;
            const int b = 18;
            const int expected = 6;
            TimeSpan runTime;
            int actual = Algorithms.GCDBinary(out runTime, a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GCDBinary_2NegativeParamsMinus30AndMinus18_6()
        {
            const int a = -30;
            const int b = -18;
            const int expected = 6;
            TimeSpan runTime;
            int actual = Algorithms.GCDBinary(out runTime, a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GCDBinary_3Params11310And5382And14586_78()
        {
            const int a = 11310;
            const int b = 5382;
            const int c = 14586;
            const int expected = 78;
            TimeSpan runTime;
            int actual = Algorithms.GCDBinary(out runTime, a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GCDBinary_4Params38688And5382And14586And11310_78()
        {
            const int a = 38688;
            const int b = 5382;
            const int c = 14586;
            const int d = 11310;
            const int expected = 78;
            TimeSpan runTime;
            int actual = Algorithms.GCDBinary(out runTime, a, b, c, d);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
