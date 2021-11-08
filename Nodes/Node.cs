using System;

namespace Nodes
{
    public class Node
    {
        public int Value { get; set; }
        public int Index { get; set; }
        public int MaxIndex { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
