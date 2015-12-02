using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSys.Series.Logic
{
    public class SeriesProcessor
    {
        private const int specialNumber1Index = 2;

        private double _y;

        public SeriesProcessor(double y = 0)
        {
            _y = y;
        }

        public SpecialNumbers GetSpecialNumbers(IEnumerable<double> series)
        {
            if (series.Count() <= specialNumber1Index)
                throw new ArgumentException(string.Format("Series must have more than {0} elements", specialNumber1Index + 1));

            throw new NotFiniteNumberException();
        }
    }
}
