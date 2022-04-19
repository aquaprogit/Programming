using System;

namespace Lab6
{
    internal class Node<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public Node<T> Left;
        public Node<T> Right;

        public Node(T value)
        {
            Value = value;
            Left = Right = null;
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
