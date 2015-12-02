using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSys.Series.Logic
{
    public class SeriesCalculator
    {
        private const double TwoPerCentModifier = 0.02d;

        public double CalculateFirstElement(double x)
        {
            var result = ((0.5d * Math.Pow(x, 2d) + (30d * x) + 10d) / 25d);
            return result;
        }

        public double CalculateGrowthRate(double firstNumber, double y)
        {
            var result = (TwoPerCentModifier * y) / 25 / (firstNumber);
            return result;
        }

        public IEnumerable<double> GenerateSeries(double firstNumber, double growthRate, int length)
        {
            throw new NotImplementedException();
        }
    }
}
