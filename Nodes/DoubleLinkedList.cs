using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    class DoubleLinkedList
    {
        private DoubleLinkedNode _root;

        public DoubleLinkedList()
        {
            _root.Next = null;
            _root.Prev = null;
        }

        public void AddFront(int value)
        {
            DoubleLinkedNode tmp = _root;
            Node prev;
            if (_root.Next == null && _root.Prev == null)
            {
                _root.Value = value;
            }
            else
            {
                while (_root.Next != null)
                {

                }
            }
        }
    }
}