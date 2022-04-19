using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    internal class Tree<T> where T : IComparable<T>
    {
        private Node<T> _root;

        public Node<T> Root { get => _root; set => _root = value; }

        public Tree(T value)
        {
            Root = new Node<T>(value);
        }
        public Tree() { }
        public T[] PostorderTreeWalk()
        {
            List<T> values = new List<T>();
            PostorderTreeWalk(_root, values);
            return values.ToArray();
        }
        public void Insert(T value)
        {
            Insert(value, ref _root);
        }
        public void Remove(T value)
        {
            Remove(value, ref _root);
        }
        public string DisplayTree()
        {
            StringBuilder output = new StringBuilder();
            DisplayNode(output, 0, _root);
            return output.ToString();
        }

        private void DisplayNode(StringBuilder output, int depth, Node<T> node)
        {
            if (node.Right != null)
                DisplayNode(output, depth + 1, node.Right);

            output.Append('\t', depth);
            output.AppendLine(node.Value.ToString());

            if (node.Left != null)
                DisplayNode(output, depth + 1, node.Left);
        }
        private void Insert(T value, ref Node<T> node)
        {
            if (node == null)
            {
                node = new Node<T>(value);
                return;
            }
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left != null)
                    Insert(value, ref node.Left);
                else
                    node.Left = new Node<T>(value);
            }
            if (value.CompareTo(node.Value) >= 0)
            {
                if (node.Right != null)
                    Insert(value, ref node.Right);
                else
                    node.Right = new Node<T>(value);
            }

        }
        private void Remove(T value, ref Node<T> node)
        {
            if (value.CompareTo(node.Value) < 0)
                Remove(value, ref node.Left);
            else if (value.CompareTo(node.Value) > 0)
                Remove(value, ref node.Right);
            else if (value.CompareTo(node.Value) == 0)
            {
                if (node.Left == null && node.Right == null)
                {
                    node = null;
                }
                else if (node.Left == null ^ node.Right == null)
                {
                    node = node.Left ?? node.Right;
                }
                else if (node.Left != null && node.Right != null)
                {
                    if (node.Left.Right == null)
                    {
                        node.Value = node.Left.Value;
                        node.Left = node.Left.Left;
                    }
                    else
                    {
                        Node<T> rightestParrent = node.Left;

                        while (rightestParrent.Right.Right != null)
                        {
                            rightestParrent = rightestParrent.Right;
                        }
                        node.Value = rightestParrent.Right.Value;
                        Remove(rightestParrent.Right.Value, ref rightestParrent.Right);
                    }
                }
            }
        }
        private void PostorderTreeWalk(Node<T> node, List<T> vs)
        {
            if (node != null)
            {
                PostorderTreeWalk(node.Left, vs);
                PostorderTreeWalk(node.Right, vs);
                vs.Add(node.Value);
            }
        }
    }
}
