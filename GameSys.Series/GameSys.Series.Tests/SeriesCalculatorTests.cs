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
        [TestCase(1, 1.62)]
        public void CanCalculateFirstElement(double x, double expectedResult)
        {
            //arrange
            var seriesCalculator = new SeriesCalculatorFixture().Create();

            //act
            var result = seriesCalculator.CalculateFirstElement(x);

            //assert
            Assert.AreEqual(expectedResult, x);
        }
    }
}
