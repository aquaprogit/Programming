using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            _elems.ToList().ForEach(elem => elem += value);
        }
        public override void DecreaseAll(int value)
        {
            _elems.ToList().ForEach(elem => elem -= value);
        }
        public override double GetAverage()
        {
            int sum = _elems.Sum();
            return (double)sum / _elems.Count();
        }
    }
}
