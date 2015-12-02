using GameSys.Series.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSys.Series.Tests.Fixtures
{
    public class SeriesProcessorFixture
    {
        private double _y;

        public SeriesProcessorFixture()
        {
            _y = 0;
        }

        public SeriesProcessorFixture SetupYConstant(double y)
        {
            _y = y;
            return this; 
        }

        public SeriesProcessor Create()
        {
            return new SeriesProcessor(_y);
        }
    }
}
