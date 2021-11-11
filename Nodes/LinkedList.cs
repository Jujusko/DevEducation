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
            if (_root == null)
            {
                return;
            }
            if (_root.Next == null)
            {
                _root = null;
                return;
            }

            tmp = _root;
            while (tmp.Next.Next != null)
            {
                tmp = tmp.Next;
            }
            tmp.Next = null;
            
        }

        public void DeleteAtHead()
        {
            Node tmp;

            if (_root == null)
            {
                return;
            }
            tmp = _root;
            tmp = tmp.Next;
            _root = tmp;
        }

        public void DeleteByIndex(int index)
        {
            Node tmp;
            Node tmp2;
            int cnt;

            if (_root == null || (_root.Next == null && index != 0))
            {
                return;
            }
            else if (_root.Next == null && index == 0)
            {
                _root = _root.Next;
                return;
            }
            if (index == 0)
            {
                _root = _root.Next;
                return;
            }
            tmp = _root;
            tmp2 = _root.Next;
            cnt = 0;
            while (tmp.Next != null)
            {

                cnt++;
                if (cnt == index)
                {
                    tmp.Next = tmp.Next.Next;
                    break;
                }
                else
                {
                    tmp = tmp.Next;
                }
            }
        }

        public void DeleteSomeElementsFromEnd(int amount)
        {
            int amoutnOfElems;
            int neededIndex;
            int cnt;
            Node tmp;

            cnt = 0;
            amoutnOfElems = GetLenght();
            if (amount < 0 || amount > amoutnOfElems)
            {
                throw new IndexOutOfRangeException("You took bad arg");
            }
            tmp = _root;
            neededIndex = amoutnOfElems - amount;
            while (tmp != null)
            {
                cnt++;
                if (cnt == neededIndex)
                {
                    tmp.Next = null;
                    break;
                }
                tmp = tmp.Next;
            }
        }

        public void DeleteSomeElementsFromHead(int amount)
        {
            int amountOfElems;
            int skipElems;


            if (_root == null && amount == 0)
            {
                return;
            }
            amountOfElems = GetLenght();
            if (amount < 0 || amount > amountOfElems)
            {
                throw new IndexOutOfRangeException("You took bad arg");
            }
            skipElems = 0;
            while (_root != null)
            {
                if (skipElems == amount)
                {
                    break;
                }
                skipElems++;
                _root = _root.Next;
            }
        }

        public void DeleteSomeElementsFromNeededIndex(int index, int amount)
        {
            Node firstToConnect;
            Node secondToConnect;
            int amountOfElems;

            if (index == 0)
            {
                DeleteSomeElementsFromHead(amount);
            }
            else
            {
                amountOfElems = GetLenght();
                if (index < 0 || amount < 0 || ((index + amount) > amountOfElems)
                    || index > amountOfElems || amount > amountOfElems)
                {
                    throw new IndexOutOfRangeException("You took bad args");
                }
                firstToConnect = _root;
                while (--index > 0)
                {
                    firstToConnect = firstToConnect.Next;
                }
                secondToConnect = firstToConnect.Next;
                while (amount-- > 0 && secondToConnect != null)
                {
                    secondToConnect = secondToConnect.Next;
                }
                firstToConnect.Next = secondToConnect;
            }
        }

        public int GetLenght()
        {
            Node tmp;
            int lenght;
            lenght = 0;

            tmp = _root;
            while (tmp != null)
            {
                tmp = tmp.Next;
                lenght++;
            }
            return lenght;
        }
        public int DeleteOneNodeByContent(int value)
        {
            int index;

            index = 0;
            if (_root != null)
            {

                if (_root.Next == null)
                {
                    if (_root.Value == value)
                    {
                        _root = null;
                    }
                    throw new ArgumentException("there is no value");
                }

                if (_root.Value == value)
                {
                    _root = _root.Next;
                    return index;
                }
                Node prev = _root;
                Node cur = _root.Next;
                while (cur != null)
                {
                    if (cur.Value == value)
                    {
                        prev.Next = cur.Next;
                        index++;
                        return index;
                    }
                    index++;
                    prev = cur;
                    cur = cur.Next;
                }
                throw new ArgumentException("there is no value");
            }
            throw new ArgumentException("there is no value");
        }

        public int DeleteAllNodesWithSameContent(int content)
        {
            int cnt = 0;
            Node tmp;
            Node prevNode;
            if (_root != null)
            {

                if (_root.Next == null)
                {
                    if (_root.Value == content)
                    {
                        _root = null;
                        cnt++;
                        return cnt;
                    }
                    throw new ArgumentException("there is no value");
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
                throw new ArgumentException("there is no value");
            }
            throw new ArgumentException("there is no value");
        }

        #endregion

        #region get some data

        public int getValueByIndex(int index)
        {
            Node tmp;
            int maxLen;

            if (_root == null)
            {
                throw new Exception("List are empty");
            }
            maxLen = GetLenght();
            if (maxLen < index || index < 0)
            {
                throw new Exception("Too big index");
            }
            tmp = _root;
            while (index-- != 0)
            {
                tmp = tmp.Next;
            }

            return tmp.Value;
        }

        public int GetIndexByContent(int content)
        {
            Node tmp;
            int index;

            if (_root == null)
            {
                throw new Exception("List are empty");
            }
            tmp = _root;
            index = 0;
            while (tmp.Value != content && tmp != null)
            {
                tmp = tmp.Next;
                index++;
                if (tmp.Value == content)
                {
                    return index;
                }
            }
            throw new Exception("there is no needed value");
        }
        public void SetContentByIndex(int index, int value)
        {
            //Не уверен на счет логики, если мы получим индекс
            // больше макс индекса, мы ведь просто
            // вернем такой же лист, исключения не нужны
            Node tmp = _root;
            int indexInList;

            if (_root == null)
            {
                throw new Exception("List are empty");
            }
            if (index < 0 || index > GetLenght())
            {
                throw new Exception("List are empty");
            }
            indexInList = 0;
            while (tmp != null)
            {
                if (index == indexInList)
                {
                    tmp.Value = value;
                    break;
                }
                indexInList++;
                tmp = tmp.Next;
            }
        }

        public void ReverseList()
        {
            //У ЭТОГО ФРАНКЕШТЕЙНА КОСТЫЛЕЙ БОЛЬШЕ, ЧЕМ КОНЕЧНОСТЕЙ
            Node tmp1;
            Node tmp2;
            Node tmp3;

            if (_root != null)
            {

                if (_root.Next == null)
                {
                    return;
                }
                if (_root.Next.Next == null)
                {
                    tmp1 = _root;
                    tmp2 = _root.Next;
                    tmp1.Next = null;
                    tmp2.Next = tmp1;
                    _root = tmp2;
                    return;
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
            
        }

        public int GetMaxContent()
        {
            Node neededNode;
            Node tmp;
            
            tmp = _root;
            neededNode = tmp;
            if (_root == null)
            {
                throw new Exception("You have empty linked list");
            }
            if (_root.Next == null)
            {
                return _root.Value;
            }
            while (tmp != null)
            {
                if (neededNode.Value < tmp.Value)
                    neededNode = tmp;
                tmp = tmp.Next;
            }
            return neededNode.Value;
        }
        public int GetMinContent()
        {
            Node neededNode;
            Node tmp;

            if (_root == null)
            {
                throw new Exception("You have empty linked list");
            }
            tmp = _root;
            neededNode = tmp;
            while (tmp.Next != null)
            {
                if (neededNode.Value > tmp.Next.Value)
                    neededNode = tmp.Next;
                tmp = tmp.Next;
            }
            return neededNode.Value;
        }

        public int GetMaxContentIndex()
        {
            Node neededNode;
            Node tmp;
            int index;
            int neededIndex;

            index = 0;
            neededIndex = 0;
            if (_root == null)
            {
                throw new Exception("List is empty");
            }
            tmp = _root;
            neededNode = _root;
            while (tmp != null)
            {
                if (tmp.Value > neededNode.Value)
                {
                    neededIndex = index;
                    neededNode = tmp;
                }
                index++;
                tmp = tmp.Next;
            }
            return neededIndex;
        }

        public int GetMinContentIndex()
        {
            Node neededNode;
            Node tmp;
            int index;
            int neededIndex;

            index = 0;
            neededIndex = 0;
            if (_root == null)
            {
                throw new Exception("List is empty");
            }
            tmp = _root;
            neededNode = _root;
            while (tmp != null)
            {
                if (tmp.Value < neededNode.Value)
                {
                    neededIndex = index;
                    neededNode = tmp;
                }
                index++;
                tmp = tmp.Next;
            }
            return neededIndex;
        }
        #endregion



        #region methods to sort list

        public void SortFromMinToMax()
        {
            Node newRoot;
            Node newNext;
            int minCont;
            if (_root != null)
            {

                if (_root.Next == null)
                {
                    return;
                }
                if (_root.Next.Next == null)
                {
                    if (_root.Value < _root.Next.Value)
                    {
                        return;
                    }
                    else
                    {
                        newRoot = _root.Next;
                        _root.Next = null;
                        newRoot.Next = _root;
                        _root = newRoot;
                        return;
                    }
                }
                newRoot = new(GetMinContent());
                minCont = newRoot.Value;
                newNext = newRoot;
                while (_root.Next != null)
                {

                    DeleteOneNodeByContent(minCont);
                    newNext.Next = new(GetMinContent());
                    newNext = newNext.Next;
                    minCont = newNext.Value;
                }
                _root = newRoot;
            }
        }

        public void SortFromMaxToMin()
        {
            Node newRoot;
            Node newNext;
            int maxCont;
            if (_root != null)
            {

                if (_root.Next == null)
                {
                    return;
                }
                if (_root.Next.Next == null)
                {
                    if (_root.Value > _root.Next.Value)
                    {
                        return;
                    }
                    else
                    {
                        newRoot = _root.Next;
                        _root.Next = null;
                        newRoot.Next = _root;
                        _root = newRoot;
                        return;
                    }
                }
                newRoot = new(GetMaxContent());
                maxCont = newRoot.Value;
                newNext = newRoot;
                while (_root.Next != null)
                {

                    DeleteOneNodeByContent(maxCont);
                    newNext.Next = new(GetMaxContent());
                    newNext = newNext.Next;
                    maxCont = newNext.Value;
                }
                _root = newRoot;
            }
        }

        #endregion


        #region methods to Work with another LinkedLists

        public void AddFront(LinkedList newList)
        {
            Node thisListEnd;

            if (newList._root != null)
            {
                if (_root != null)
                {
                    thisListEnd = _root;
                    while (thisListEnd.Next != null)
                    {
                        thisListEnd = thisListEnd.Next;
                    }
                    thisListEnd.Next = newList._root;
                }
                else
                {
                    _root = newList._root;
                }
            }
        }

        public void AddBack(LinkedList newList)
        {
            Node newRoot;
            if (newList._root != null)
            {
                if (_root != null)
                {
                    newRoot = newList._root;
                    while (newList._root.Next != null)
                    {
                        newList._root = newList._root.Next;
                    }
                    newList._root.Next = _root;
                    _root = newRoot;
                }
                else
                {
                    _root = newList._root;
                }
            }
        }

        public void AddByIndex(int index, LinkedList newList)
        {
            Node oldRootStart;
            Node oldRootEnd;

            Node newListEnd;
            Node newListStart;
            int cnt;
            if (index == 0)
            {
                AddBack(newList);
            }
            else if (index == GetLenght())
            {
                AddFront(newList);
            }
            else
            {
                if (newList._root != null)
                {
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
            }
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
