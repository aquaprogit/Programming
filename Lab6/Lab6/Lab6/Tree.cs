using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    internal class Tree
    {
        private Node _root;

        public Node Root { get => _root; set => _root = value; }

        public Tree(int value)
        {
            Root = new Node(value);
        }
        public Tree() { }
        public int[] PostorderTreeWalk()
        {
            List<int> nodes = new List<int>();
            PostorderTreeWalk(_root, nodes);
            return nodes.ToArray();
        }
        public void Insert(int value)
        {
            Insert(value, ref _root);
        }
        public void Remove(int value)
        {
            Remove(value, ref _root);
        }
        public string DisplayTree()
        {
            StringBuilder output = new StringBuilder();
            DisplayNode(output, 0, _root);
            return output.ToString();
        }

        private void DisplayNode(StringBuilder output, int depth, Node node)
        {
            if (node.Right != null)
                DisplayNode(output, depth + 1, node.Right);

            output.Append('\t', depth);
            output.AppendLine(node.Value.ToString());

            if (node.Left != null)
                DisplayNode(output, depth + 1, node.Left);
        }
        private void Insert(int value, ref Node node)
        {
            if (node == null) node = new Node(value);

            if (value < node.Value)
            {
                if (node.Left != null)
                    Insert(value, ref node.Left);
                else
                    node.Left = new Node(value);
            }
            if (value >= node.Value)
            {
                if (node.Right != null)
                    Insert(value, ref node.Right);
                else
                    node.Right = new Node(value);
            }

        }
        private void Remove(int value, ref Node node)
        {
            if (value < node.Value)
                Remove(value, ref node.Left);
            else if (value > node.Value)
                Remove(value, ref node.Right);
            else if (value == node.Value)
            {
                if (node.Left == null && node.Right == null)
                {
                    node = null;
                }
                else if (node.Left == null ^ node.Right == null)
                {
                    var existingChild = node.Left ?? node.Right;
                    if (node.Left == null)
                    {
                        node = node.Right;
                        node.Right = null;
                    }
                    else
                    {
                        node = node.Left;
                        node.Left = null;
                    }
                }
                else if (node.Left != null && node.Right != null)
                {
                    if (node.Right.Left == null)
                    {
                        node.Value = node.Right.Value;
                        node.Right.Value = node.Right.Right.Value;
                    }
                    else
                    {
                        node.Value = node.Right.Left.Value;
                        Remove(node.Right.Left.Value, ref node.Right.Left);
                    }
                }
            }
        }
        private void PostorderTreeWalk(Node node, List<int> vs)
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
