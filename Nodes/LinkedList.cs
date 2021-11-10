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

        #region Constructors
        public LinkedList()
        {
            _root = null;
        }
        public LinkedList(int value)
        {
            _root = new Node(value);
            _root.Index = 0;
        }

        public LinkedList(int [] array)
        {
            if (array.Length == 0)
            {
                _root = null;
                return;
            }
            Node newN = new Node(array[0]);
            int cnt = 0;
            _root = newN;
            while (++cnt < array.Length)
            {
                newN.Next = new Node(array[cnt]);
                newN = newN.Next;
            }
        }
        #endregion

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
            Node insertNode;
            Node tmp;
            int rootsIndex;

            rootsIndex = 1;
            tmp = _root;
            insertNode = new Node(value);
            if (index == 0)
            {
                insertNode.Next = _root;
                _root = insertNode;
                return;
            }
            while(tmp.Next != null && rootsIndex != index)
            {
                tmp = tmp.Next;
                rootsIndex++;
            }
            if (index == rootsIndex)
            {
                insertNode.Next = tmp.Next;
                tmp.Next = insertNode;
            }
            else
                throw new ArgumentException("index is too big");

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
            if (neededIndex < 1)
            {
                throw new ArgumentException("Too much nodes to delete");
            }
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
            SetSomeData();
            if (amount > _root.MaxIndex)
            {
                throw new ArgumentException("Too much nodes to delete");
            }
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

            SetSomeData();
            if (amount + index > _root.MaxIndex)
            {
                throw new ArgumentException("Too much nodes to delete");
            }
            if (index < 0 || amount < 0)
            {
                throw new ArgumentException("Bad args");
            }
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

        public void DeleteOneNodeByContent(int value)
        {
            if (_root.Next == null)
            {
                if (_root.Value == value)
                {
                    _root = null;
                }
                return;
            }


            Node prev = _root;
            Node cur = _root.Next;
            while (cur != null)
            {
                if (cur.Value == value)
                {
                    prev.Next = cur.Next;
                    break;
                }
                prev = cur;
                cur = cur.Next;
            }
        }

        public int DeleteAllNodesWithSameContent(int content)
        {
            int cnt = 0;
            Node tmp;
            Node prevNode;
            if (_root.Next == null)
            {
                if (_root.Value == content)
                {
                    _root = null;
                    cnt++;
                }
                return cnt;
            }
            while (_root.Next != null)
            {
                if (_root.Value != content)
                    break;
                _root = _root.Next;
            }
            prevNode = _root;
            tmp = _root.Next;
            while (tmp != null)
            {
               if (tmp.Value == content)
               {
                    tmp = tmp.Next;
                    prevNode.Next = tmp;
                    cnt++;
               }
               else
               {
                    tmp = tmp.Next;
                    prevNode = prevNode.Next;
               }
            }
            return cnt;
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
            if (_root.Next == null)
            {
                return;
            }
            if (_root.Next.Next == null)
            {
                tmp1 = _root.Next;
                _root.Next = null;
                tmp1.Next = _root;
                _root = tmp1;
            }
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


        #region methods to Work with another LinkedLists

        public void AddAnotherListToFront(LinkedList newList)
        {
            Node thisListEnd;

            thisListEnd = _root;
            while (thisListEnd.Next != null)
            {
                thisListEnd = thisListEnd.Next;
            }
            thisListEnd.Next = newList._root;
        }

        public void AddAnotherListAtBack(LinkedList newList)
        {
            Node newRoot;

            newRoot = newList._root;
            while (newList._root.Next != null)
            {
                newList._root = newList._root.Next;
            }
            newList._root.Next = _root;
            _root = newRoot;
        }

        public void AddAnotherListByIndex(LinkedList newList, int index)
        {
            Node oldRootStart;
            Node oldRootEnd;

            Node newListEnd;
            Node newListStart;

            int cnt;

            cnt = 0;
            newListStart = newList._root;
            while (newList._root.Next != null)
            {
                newList._root = newList._root.Next;
            }
            newListEnd = newList._root;
            oldRootStart = _root;
            while (oldRootStart.Next != null && cnt < index)
            {
                oldRootStart = oldRootStart.Next;
                cnt++;
            }
            oldRootEnd = oldRootStart.Next;
            oldRootStart.Next = newListStart;
            newListEnd.Next = oldRootEnd;
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
        public override bool Equals(object obj)
        {

            LinkedList myNode = (LinkedList)obj;
            Node tmp1;
            Node tmp2;

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
