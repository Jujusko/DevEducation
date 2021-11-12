using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    public class DLList
    {
        private DLNode _root;
        private DLNode _tail;
        public int Len;

        public DLList()
        {
            _root = null;
            _tail = null;
        }

        public DLList(int value)
        {
            _root = new DLNode(value);
            _tail = _root;
            Len = 1;
        }

        public DLList(int[] arr)
        {
            int i;

            if (arr.Length == 0)
            {
                _root = null;
                _tail = _root;
                Len = 0;
                return;
            }
            DLNode newN = new(arr[0]);
            _root = newN;
            i = 0;
            while(++i < arr.Length)
            {
                newN.Next = new(arr[i]);
                newN.Next.Prev = newN;
                newN = newN.Next;
            }
            Len = arr.Length;
            _tail = newN;
        }
        public void AddFront(int value)
        {
            if (_root != null)
            {
                DLNode newNode = new(value);
                _tail.Next = newNode;
                _tail.Next.Prev = _tail;
                _tail = _tail.Next;
                Len++;
            }
            else
            {
                _root = new DLNode(value);
                _tail = _root;
                Len = 1;
            }
        }

        public void AddBack(int value)
        {
            if (_root != null)
            {
                DLNode newNode = new(value);
                newNode.Next = _root;
                newNode.Next.Prev = newNode;
                _root = newNode;
                Len++;
            }
            else
            {
                _root = new DLNode(value);
                _tail = _root;
                Len = 1;
            }
        }

        public void AddByIndex(int index, int value)
        {
            int rootOrTail;
            int steps;
            DLNode tmp;
            DLNode createdNode;

            if (index < 0 || index > Len)
            {
                throw new ArgumentException("Bad index");
            }

            createdNode = new(value);

            rootOrTail = Len / 2 - index;
            if (_root != null)
            {
                if (rootOrTail > 0)
                {
                    tmp = _root;
                    while (--index != 0)
                    {
                        tmp = tmp.Next;
                    }
                    createdNode.Next = tmp.Next;
                    createdNode.Prev = tmp;
                    tmp.Next = createdNode;
                }
                else
                {
                    steps = Len - index;
                    tmp = _tail;
                    while (--steps != 0)
                    {
                        tmp = tmp.Prev;
                    }
                    createdNode.Prev = tmp.Prev;
                    createdNode.Next = tmp;
                    tmp.Prev = createdNode;
                }
            }
            else
            {
                if (index == 0)
                {
                    _root = new DLNode(value);
                    _tail = _root;
                    Len = 1;
                }
                else
                {
                    throw new ArgumentException("Bad index");
                }
            }
        }

        #region Equal and ToString
        public override bool Equals(object obj)
        {

            DLList myNode = (DLList)obj;
            DLNode tmp1;
            DLNode tmp2;

            tmp1 = _root;
            tmp2 = myNode._root;
            if (tmp1 == null && tmp2 == null)
            {
                return true;
            }
            while (tmp2 != null && tmp1 != null)
            {
                if ((tmp1.Next == null && tmp2.Next != null)
                || (tmp1.Next != null && tmp2.Next == null))
                {
                    return false;
                }
                if (tmp2.Value != tmp1.Value)
                {
                    return false;
                }
                tmp2 = tmp2.Next;
                tmp1 = tmp1.Next;
            }
            return true;
        }
        public override string ToString()
        {
            string s = "";
            if (_root == null)
                return s;
            DLNode myNode = _root;
            while (myNode != null)
            {
                s += myNode.Value + " ";
                myNode = myNode.Next;
            }
            return s;
        }
        #endregion
    }
}

/* 
    добавление значения по индексу
    удаление из конца одного элемента
    удаление из начала одного элемента
    удаление по индексу одного элемента
    удаление из конца N элементов
    удаление из начала N элементов
*/