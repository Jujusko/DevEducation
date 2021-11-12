using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    public class DLNode
    {
        public int Value { get; set; }
        public DLNode Next { get; set; }
        public DLNode Prev { get; set; }


        public DLNode(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }

        public override string ToString()
        {
            DLNode myNode = Next;

            string s = "";
            s += Value + " ";
            while (myNode != null)
            {
                s += myNode.Value + " ";

                myNode = myNode.Next;
            }
            return s;
        }
    }
}
