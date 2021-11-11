using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    class DoubleLinkedNode
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node Prev { get; set; }
        public DoubleLinkedNode(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
}
