using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class TArray<T> where T : struct
    {
        protected T[] _elems;
        protected Random _random = new Random();
        public T this[int index] {
            get => _elems[index];
            set => _elems[index] = value;
        }
        public int Count => _elems.Length;
        public abstract void IncreaseAll(T value);
        public abstract void DecreaseAll(T value);

        public abstract double GetAverage();
    }
}
