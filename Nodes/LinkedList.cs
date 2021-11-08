using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    public class LinkedList
    {
        private Node _root;

        public LinkedList()
        {
            _root = null;
        }
        public LinkedList(int value)
        {
            _root = new Node(value);
            _root.Index = 0;
        }

        #region methods to ADD content
        public void AddFront(int value)
        {
            Node    tmp = _root;

            if (_root != null)
            {
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(value);
            }
            else
            {
                _root = new Node(value);
            }
            SetSomeData();
        }
        public void AddBack(int value)
        {
            Node tmp = new Node(value);
            if (_root == null)
                _root = tmp;
            else
            {
                tmp.Next = _root;
                _root = tmp;
            }
            SetSomeData();
        }

        public void AddByIndex(int index, int value)
        {
            Node tmp;
            Node tmp2;
            tmp = _root;
            while (tmp.Next.Index != index)
            {
                tmp = tmp.Next;
            }
            tmp2 = tmp.Next;
            tmp.Next = new Node(value);
            tmp.Next.Next = tmp2;
            SetSomeData();
        }
        #endregion

        #region delete content

        public void DeleteFromEnd()
        {
            Node tmp;

            tmp = _root;
            while (tmp.Next.Next != null)
            {
                tmp = tmp.Next;
            }
            tmp.Next = null;
            SetSomeData();
        }

        public void DeleteAtHead()
        {
            Node tmp;

            tmp = _root;
            tmp = tmp.Next;
            _root = tmp;
            SetSomeData();
        }

        public void DeleteByIndex(int index)
        {
            Node tmp;
            Node tmp2;

            tmp = _root;
            if (_root.Index == index)
            {
                _root = _root.Next;
                return;
            }
            if (index != _root.MaxIndex)
            {
                while (tmp.Next.Index != index)
                {
                    tmp = tmp.Next;
                }
                tmp2 = tmp.Next.Next;
                tmp.Next = tmp2;
            }
            else if (index == _root.MaxIndex)
            {
                DeleteFromEnd();
            }
            SetSomeData();
        }

        public void DeleteSomeElementsFromEnd(int amount)
        {
            int maxIndex;
            int neededIndex;
            Node tmp;

            maxIndex = 0;
            tmp = _root;
            while (tmp.Next !=null)
            {
                tmp = tmp.Next;
                maxIndex++;
            }
            neededIndex = maxIndex - amount;
            tmp = _root;
            while (tmp.Index != neededIndex)
            {
                tmp = tmp.Next;
            }
            tmp.Next = null;
            SetSomeData();
        }

        public void DeleteSomeElementsFromHead(int amount)
        {
            while (amount != 0)
            {
                _root = _root.Next;
                amount--;
            }
            SetSomeData();
        }

        public void DeleteSomeElementsFromNeededIndex(int index, int amount)
        {
            Node tmp;
            Node tmp2;

            tmp = _root;
            while (tmp.Next.Index != index)
            {
                tmp = tmp.Next;
            }
            tmp2 = tmp;
            while (tmp.Index != amount + index)
            {
                tmp = tmp.Next;
            }
            tmp2.Next = tmp;
            SetSomeData();
        }
        #endregion

        #region get some data

        public int GetMaxIndex()
        {
            return _root.MaxIndex + 1;
        }

        public Node getNodeByIndex(int index)
        {
            Node tmp;

            tmp = _root;
            while (tmp.Index != index && tmp.Next != null)
            {
                tmp = tmp.Next;
            }

            return tmp;
        }

        public int GetIndexByContent(int content)
        {
            Node tmp;

            tmp = _root;
            while (tmp.Value != content && tmp != null)
            {
                tmp = tmp.Next;
            }
            return tmp.Index;
        }
        public void SetContentByIndex(int index, int value)
        {
            Node tmp = _root;

            while (tmp.Index != index && tmp != null)
            {
                tmp = tmp.Next;
            }
            if (tmp == null)
            {
                throw new ArgumentException("You took bad index");
                return;
            }
            tmp.Value = value;
        }

        public void ReverseList()
        {
            //У ЭТОГО ФРАНКЕШТЕЙНА КОСТЫЛЕЙ БОЛЬШЕ, ЧЕМ КОНЕЧНОСТЕЙ
            Node tmp1;
            Node tmp2;
            Node tmp3;


            //if на один и на  2 элема

            tmp1 = _root;
            tmp2 = _root.Next;
            tmp3 = _root.Next.Next;
            tmp1.Next = null;
            while (tmp2.Next != null)
            {
                tmp2.Next = tmp1;//2 на 1 .. 5 na 4
                tmp1 = tmp3.Next;//now 4 .. now 7
                if (tmp3.Next == null)
                {
                    tmp3.Next = tmp2;
                    _root = tmp3;
                    break;
                }
                tmp3.Next = tmp2;//3 na 2 .. 6 na 5
                tmp2 = tmp1.Next;//now 5 .. 
                if (tmp1.Next == null)
                {
                    tmp1.Next = tmp3;
                    _root = tmp1;
                    break;
                }
                tmp1.Next = tmp3;//4 na 3
                tmp3 = tmp2.Next;//now 6
                if (tmp2.Next == null)
                {
                    tmp2.Next = tmp1;
                    _root = tmp2;
                    break;
                }
            }
            
        }

        public Node GetMaxContent()
        {
            Node neededNode;
            Node tmp;
            SetSomeData();
            tmp = _root;
            neededNode = tmp;
            while (tmp != null)
            {
                if (neededNode.Value < tmp.Value)
                    neededNode = tmp;
                tmp = tmp.Next;
            }
            return neededNode;
        }
        public Node GetMinContent()
        {
            Node neededNode;
            Node tmp;

            tmp = _root;
            neededNode = tmp;
            while (tmp.Next != null)
            {
                if (tmp.Value > tmp.Next.Value)
                    neededNode = tmp.Next;
                tmp = tmp.Next;
            }
            return neededNode;
        }

        public int GetMaxContentIndex()
        {
            Node neededNode;
            Node tmp;
            SetSomeData();

            tmp = _root;
            neededNode = null;
            while (tmp.Next != null)
            {
                if (tmp.Value < tmp.Next.Value)
                    neededNode = tmp;
                tmp = tmp.Next;
            }
            return neededNode.Index;
        }

        public int GetMinContentIndex()
        {
            Node neededNode;
            Node tmp;
            SetSomeData();

            tmp = _root;
            neededNode = null;
            while (tmp.Next != null)
            {
                if (tmp.Value > tmp.Next.Value)
                    neededNode = tmp;
                tmp = tmp.Next;
            }
            return neededNode.Index;
        }
        #endregion


        #region some utils
        public void WriteContent()
        {
            Node tmp;

            tmp = _root;
            while (tmp != null)
            {
                Console.Write(tmp.Value + " ");
                tmp = tmp.Next;
            }
            Console.WriteLine();
        }
        private void SetSomeData()
        {
            Node tmp;
            int index;

            index = 0;
            tmp = _root;
            while (tmp != null)
            {
                tmp.Index = index;
                tmp = tmp.Next;
                index++;
            }
            tmp = _root;
            while (tmp != null)
            {
                tmp.MaxIndex = index;
                tmp = tmp.Next;
            }
        }
        #endregion

        #region methods to sort list

        public void SortFromMinToMax ()
        {
            Node head;
            Node saveMin;
            Node tmp;
            Node treat;

            saveMin = GetMinContent();
            DeleteByIndex(saveMin.Index);
            head = saveMin;
            treat = head;
            tmp = _root;
            while (tmp != null)
            {
                saveMin = GetMinContent();
                head.Next = saveMin;
                head = head.Next;
                DeleteByIndex(saveMin.Index);
                tmp = _root;
            }
            _root = treat;
        }
        public void SortFromMaxToMin()
        {
            Node head;
            Node saveMax;
            Node tmp;
            Node treat;

            saveMax = GetMaxContent();
            DeleteByIndex(saveMax.Index);
            head = saveMax;
            treat = head;
            tmp = _root;
            while (tmp != null)
            {
                saveMax = GetMaxContent();
                head.Next = saveMax;
                head = head.Next;
                DeleteByIndex(saveMax.Index);
                tmp = _root;
            }
            _root = treat;
        }
        #endregion

        public override bool Equals(object obj)//obj = actual
        {

            Node myNode = (Node)obj;

            while (myNode != null)
            {
                if (myNode.Value != _root.Value)
                    return false;
                if (_root == null && myNode != null)
                    return false;
                if (_root != null && myNode == null)
                    return false;

                myNode = myNode.Next;
                _root = _root.Next;
            }
            return true;
        }
        
        public override string ToString()
        {
            string s = "";
            if (_root == null)
                return s;
            Node myNode = _root;
            while (myNode != null)
            {
                s += myNode.Value + " ";
                myNode = myNode.Next;
            }
            return s;
        }
        
    }
}
