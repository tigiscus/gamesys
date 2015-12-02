﻿using GameSys.Series.Tests.Fixtures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSys.Series.Tests
{
    [TestFixture]
    public class SeriesProcessorTests
    {
        [Test]
        [TestCase(0, 160d)]
        [TestCase(1, 160d)]
        [TestCase(2, 160d)]
        [ExpectedException(typeof(ArgumentException))]
        public void CanThrowExceptionIfCollectionHasLessThan3Elements(int size, double z)
        {
            //arrange
            var seriesProcessor = new SeriesProcessorFixture().Create();

            //act
            var result = seriesProcessor.GetSpecialNumbers(Enumerable.Range(0, size).Select(p => Convert.ToDouble(p)), z);
        }

        [Test]
        [TestCase(new[] { 1.62d, 4d, 6.5d }, 160d, 6.5d)]
        public void CanFindNumber1(double[] series, double z, double expectedResult)
        {
            //arrange
            var seriesProcessor = new SeriesProcessorFixture().Create();

            //act
            var result = seriesProcessor.GetSpecialNumbers(series, z);

            //assert
            Assert.AreEqual(expectedResult, result.Number1);
        }

        [Test]
        [TestCase(1000d, 160d, new[] { 1.62d, 4d, 6.5d, 10.75d, 17.25d }, 6.5d)]
        [TestCase(525d, 100d, new[] { 1.62d, 4d, 6.5d, 10.75d, 17.25d }, 6.5d)]
        public void CanFindNumber2(double y, double z, double[] series, double expectedResult)
        {
            //arrange
            var seriesProcessor = new SeriesProcessorFixture().SetupYConstant(y).Create();

            //act
            var result = seriesProcessor.GetSpecialNumbers(series, z);

            //assert
            Assert.AreEqual(expectedResult, result.Number2);
        }
    }
}
