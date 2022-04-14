﻿using System;
using System.Linq;

namespace ConsoleApp1
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
