using System;
using System.Linq;

namespace Lab5
{
    internal class IntArray : TArray<int>
    {
        public IntArray(int length)
        {
            if (length < 0) throw new ArgumentOutOfRangeException("length");

            _elems = new int[length];
        }
        public override void IncreaseAll(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                _elems[i] += value;
            }
        }
        public override void DecreaseAll(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                _elems[i] -= value;
            }
        }
        public override double GetAverage()
        {
            int sum = _elems.Sum();
            return (double)sum / _elems.Count();
        }

        public override void FillRandomly()
        {
            for (int i = 0; i < Count; i++)
            {
                _elems[i] = _random.Next(-50, 51);
            }
        }
    }
}
