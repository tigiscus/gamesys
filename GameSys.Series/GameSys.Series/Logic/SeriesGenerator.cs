using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSys.Series.Logic
{
    public class SeriesGenerator
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

        public IEnumerable<double> GenerateSeries(double firstNumber, double growthRate, int length, bool round = false)
        {
            yield return firstNumber;
            for (int i = 1; i < length; i++)
                yield return Round(growthRate * Math.Pow(firstNumber, i), round);
        }

        private double Round(double value, bool shouldRound)
        {
            var result = value;
            if (shouldRound)
            {
                result = Math.Round(value * 4d, MidpointRounding.ToEven) / 4d;
            }
            return result;
        }
    }
}
