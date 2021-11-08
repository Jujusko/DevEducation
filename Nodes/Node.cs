using System;

namespace Nodes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public int Index { get; set; }
        public int MaxIndex { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
        /*
        public override bool Equals(object obj)
        {
            int i;

            Node myNode = (Node)obj;

            while (myNode != null)
            {
                if (myNode.Value !=)
            }
            return true;
        }
        */
        public override string ToString()
        {
            Node myNode = Next;//_root

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
