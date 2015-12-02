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
    }
}
