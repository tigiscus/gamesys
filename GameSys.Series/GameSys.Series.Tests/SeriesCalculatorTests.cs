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
            Assert.That(expectedResult, Is.EqualTo(result).Within(0.1));
        }

        [Test]
        [TestCase(1.62d, 2.5d, 5, new[] { 1.62d, 4.05d, 6.561d, 10.62882d, 17.2186884d })]
        public void CanGenerateSeries(double firstElement, double growthRate, int length, double[] expectedResult)
        {
            //arrange
            var seriesCalculator = new SeriesCalculatorFixture().Create();

            //act
            var result = seriesCalculator.GenerateSeries(firstElement, growthRate, length);

            //assert
            for(int i = 0; i < expectedResult.Length; i++)
              Assert.That(expectedResult[i], Is.EqualTo(result.ElementAt(i)).Within(0.000001));
        }
    }
}
