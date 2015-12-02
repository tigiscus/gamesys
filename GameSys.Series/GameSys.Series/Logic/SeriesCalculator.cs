using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSys.Series.Logic
{
    public class SeriesCalculator
    {
        public double CalculateFirstElement(double x)
        {
            var result = ((0.5d * Math.Pow(x, 2d) + (30d * x) + 10d) / 25d);
            return result;
        }
    }
}
