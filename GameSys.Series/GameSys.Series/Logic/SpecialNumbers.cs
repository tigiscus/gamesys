using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSys.Series.Logic
{
    public class SpecialNumbers
    {
        public SpecialNumbers(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public double Number1 { get; set; }
        public double Number2 { get; set; }
    }
}
