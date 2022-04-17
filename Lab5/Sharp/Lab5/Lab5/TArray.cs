using System;
using System.Collections;

namespace Lab5
{
    internal abstract class TArray<T> : IEnumerable
    {
        protected T[] _elems;
        protected static Random _random = new Random();
        public T this[int index] {
            get => _elems[index];
            set => _elems[index] = value;
        }
        public int Count => _elems.Length;
        public abstract void IncreaseAll(T value);
        public abstract void DecreaseAll(T value);
        public abstract void FillRandomly();
        public abstract double GetAverage();

        public IEnumerator GetEnumerator()
        {
            return _elems.GetEnumerator();
        }
    }
}
