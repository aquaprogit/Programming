using System;
using System.Linq;

namespace Lab5
{
    internal class DoubleArray : TArray<double>
    {
        public DoubleArray(int length)
        {
            if (length < 0) throw new ArgumentOutOfRangeException("length");
            _elems = new double[length];
        }

        public override void DecreaseAll(double value)
        {
            _elems.ToList().ForEach(elem => elem -= value);
        }

        public override void FillRandomly()
        {
            for (int i = 0; i < Count; i++)
            {
                _elems[i] = _random.GetDouble(-25, 26);
            }
        }

        public override double GetAverage()
        {
            double sum = _elems.Sum();
            return sum / _elems.Count();
        }

        public override void IncreaseAll(double value)
        {
            _elems.ToList().ForEach(elem => elem += value);
        }
    }
}
