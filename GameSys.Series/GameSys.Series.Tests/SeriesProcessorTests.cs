using GameSys.Series.Tests.Fixtures;
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
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [ExpectedException(typeof(ArgumentException))]
        public void CanThrowExceptionIfCollectionHasLessThan3Elements(int size)
        {
            //arrange
            var seriesProcessor = new SeriesProcessorFixture().Create();

            //act
            var result = seriesProcessor.GetSpecialNumbers(Enumerable.Range(0, size).Select(p => Convert.ToDouble(p)));
        }

        [Test]
        [TestCase(new[] { 1.62d, 4d, 6.5d }, 6.5d)]
        public void CanFindNumber1(double[] series, double expectedResult)
        {
            //arrange
            var seriesProcessor = new SeriesProcessorFixture().Create();

            //act
            var result = seriesProcessor.GetSpecialNumbers(series);

            //assert
            Assert.AreEqual(expectedResult, result.Number1);
        }
    }
}
