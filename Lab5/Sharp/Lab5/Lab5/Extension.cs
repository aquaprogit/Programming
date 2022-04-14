using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal static class Extension
    {
        public static double GetDouble(this Random random, double minValue, double maxValue)
        {
            return Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
}
