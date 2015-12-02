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
    public class SeriesCalculatorTests
    {
        [Test]
        [TestCase(1d, 1.62d)]
        public void CanCalculateFirstElement(double x, double expectedResult)
        {
            //arrange
            var seriesCalculator = new SeriesCalculatorFixture().Create();

            //act
            var result = seriesCalculator.CalculateFirstElement(x);

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(1.62d, 5062.5d, 2.5d)]
        public void CanCalculateGrowthRate(double firstElement, double y, double expectedResult)
        {
            //arrange
            var seriesCalculator = new SeriesCalculatorFixture().Create();

            //act
            var result = seriesCalculator.CalculateGrowthRate(firstElement, y);

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
