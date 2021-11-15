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
                    if (index == 0)
                    {
                        AddFront(value);
                    }
                    else
                    {
                        tmp = _root;
                        while (--index != 0)
                        {
                            tmp = tmp.Next;
                        }
                        createdNode.Next = tmp.Next;
                        createdNode.Prev = tmp;
                        tmp.Next = createdNode;
                        Len++;
                    }
                }
                else
                {
                    steps = Len - index;
                    if (steps == 0)
                    {
                        AddFront(value);
                    }
                    else
                    {
                        tmp = _tail;
                        while (--steps != 0)
                        {
                            tmp = tmp.Prev;
                        }
                        createdNode.Next = tmp;
                        createdNode.Prev = tmp.Prev;
                        tmp.Prev.Next = createdNode;
                        tmp.Prev = createdNode;
                        Len++;
                    }
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

        public void DeleteFromEnd()
        {
            if (_root != null)
            {
                _tail = _tail.Prev;
                if (_tail == null)
                {
                    _root = null;
                }
                else
                {
                    _tail.Next = null;
                }
                Len--;
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public void DeleteFromHead()
        {
            if (_root != null)
            {
                _root = _root.Next;
                if (_root != null)
                {
                    _root.Prev = null;
                }
                Len--;
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public void DeleteByIndex(int index)
        {
            int rootOrTail;
            int steps;
            DLNode tmp;

            rootOrTail = Len / 2 - index;
            if (index < 0 || index >= Len)
            {
                throw new ArgumentException($"You took bad index. Try something that less than {Len} and bigger than 0");
            }
            if (_root != null)
            {
                if (index == 0)
                {
                    DeleteFromHead();
                    return;
                }
                if (rootOrTail > 0)
                {
                    tmp = _root;

                    while (index-- != 0)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next.Prev = tmp.Prev;
                    tmp.Prev.Next = tmp.Next;
                    Len--;
                }
                else
                {
                    steps = Len - index;
                    tmp = _tail;
                    while (--steps != 0)
                    {
                        tmp = tmp.Prev;
                    }
                    tmp.Prev.Next = tmp.Next;
                    tmp.Prev = tmp.Prev.Prev;
                    Len--;
                }

            }
            else
            {
                throw new ArgumentException("List is empty");
            }
        }

        public void DeleteFromEndSomeElems(int amount)
        {
            if (amount < 0 || amount >= Len)
            {
                throw new ArgumentException("Bad amount");
            }
            if (_root != null)
            {
                while (amount-- != 0)
                {
                    _tail = _tail.Prev;
                }
                if (_tail != null)
                {
                    _tail.Next = null;
                }
                else
                {
                    _root = null;
                }
                Len -= amount;
            }
            else if (amount != 0)
            {
                throw new ArgumentException("List is empty");
            }
        }

        public void DeleteFromHeadSomeElems(int amount)
        {
            if (amount < 0 || (amount > Len && _root != null))
            {
                throw new ArgumentException($"Too big Lists to delete, it should being less than {Len}");
            }
            if (_root != null)
            {
                while (amount-- != 0)
                {
                    _root = _root.Next;
                }
                if (_root != null)
                {
                    _root.Prev = null;
                }
                else
                {
                    _tail = null;
                }
                Len -= amount;
            }
            else if (amount != 0)
            {
                throw new ArgumentException("List is empty");
            }
        }

        public void DeleteByIndexSomeElems(int index, int amount)
        {
            int helper;

            DLNode tmp1;
            DLNode tmp2;

            if (amount > Len || amount < 0 || index > Len || index < 0 || (index + amount) > Len)
            {
                throw new ArgumentException($"Wrong args. Summ of index and amount must being less than" +
                    $"{Len} and each arg must being less than {Len} and bigger than 0");
            }
            if (_root != null)
            {
                if (index >= Len / 2)
                {
                    if ((index + amount) == Len-1)
                    {
                        DeleteFromEndSomeElems(amount);
                    }
                    else
                    { 
                        helper = Len;
                        tmp1 = _tail;
                        while((index + amount) <= helper--)
                        {
                            tmp1 = tmp1.Prev;
                        }
                        tmp2 = tmp1.Prev;
                        while (--helper >= index)
                        {
                            tmp2 = tmp2.Prev;
                            Console.WriteLine(tmp2.Value);
                        }
                        tmp1.Prev = tmp2;
                        tmp2.Next = tmp1;
                        Len -= amount;
                    }
                }
                else
                {
                    if (index == 0)
                    {
                        DeleteFromHeadSomeElems(amount);
                    }
                    else
                    {
                        tmp1 = _root;
                        while (--index != 0)
                        {
                            tmp1 = tmp1.Next;
                        }
                        tmp2 = tmp1.Next;
                        while (amount-- != 0)
                        {
                            tmp2 = tmp2.Next;
                        }
                        tmp1.Next = tmp2;
                        tmp2.Prev = tmp1;
                        Len -= amount;
                    }
                }
            }
        }

        public int GetIndexByValue(int value)
        {
            DLNode tmp;
            int index;

            index = 0;
            tmp = _root;
            while (tmp != null)
            {
                if (tmp.Value == value)
                {
                    return index;
                }
                tmp = tmp.Next;
                index++;
            }
            throw new ArgumentException("There is no needed value");
        }
        
        public void ChangeByIndex(int index, int value)
        {
            int     rootOrTail;
            DLNode  tmp;

            if (_root != null)
            {
                if (index < 0 || index >= Len)
                {
                    throw new Exception($"You took bad index. Take arg less than {Len} and bigger than 0");
                }
                rootOrTail = Len / 2 - index;
                if (rootOrTail > 0)
                {
                    tmp = _root;

                    while (--index >= 0)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Value = value;
                }
                else
                {
                    tmp = _tail;
                    rootOrTail = Len - index;
                    rootOrTail--;
                    while (--rootOrTail >= 0)
                    {
                        tmp = tmp.Prev;
                    }
                    tmp.Value = value;
                }
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public void Reverse()
        {
            DLNode reversed;
            DLNode saveHead;
            DLNode temp;
            
            if (_root != null && _root.Next != null)
            {
                reversed = new(_tail.Value);
                reversed.Prev = null;
                saveHead = reversed;
                while (_tail.Prev != null)
                {
                    _tail = _tail.Prev;
                    reversed.Next = new(_tail.Value);
                    reversed.Next.Prev = reversed;
                    reversed = reversed.Next;
                }
                _tail = reversed;

                _root = saveHead;
            }
            else
            {
                if (_root.Next != null)
                {
                    _root = _tail;
                    _root.Next = _tail.Prev;
                    _root.Next.Prev = _root;
                }
            }
        }

        #region Min&Max
        public int GetMaxValue()
        {
            int     maxValue;
            DLNode  fromRoot;
            DLNode fromTail;

            if (_root != null)
            {
                fromRoot = _root;
                fromTail = _tail;
                maxValue = fromRoot.Value;
                while (fromRoot.Value != fromTail.Value)
                {
                    if (maxValue < fromRoot.Value)
                    {
                        maxValue = fromRoot.Value;
                    }
                    if (maxValue < fromTail.Value)
                    {
                        maxValue = fromTail.Value;
                    }
                    fromRoot = fromRoot.Next;
                    if (fromRoot == fromTail)//NEED TO OPTIM
                    {
                        if (maxValue < fromRoot.Value)
                        {
                            maxValue = fromRoot.Value;
                        }
                        break;
                    }
                    fromTail = fromTail.Prev;
                    if (fromRoot == fromTail)
                    {
                        if (maxValue < fromTail.Value)
                        {
                            maxValue = fromTail.Value;
                        }
                        break;
                    }
                }
                return maxValue;
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public int GetMinValue()
        {
            int maxValue;
            DLNode fromRoot;
            DLNode fromTail;

            if (_root != null)
            {
                fromRoot = _root;
                fromTail = _tail;
                maxValue = fromRoot.Value;
                while (fromRoot.Value != fromTail.Value)
                {
                    if (maxValue > fromRoot.Value)
                    {
                        maxValue = fromRoot.Value;
                    }
                    if (maxValue > fromTail.Value)
                    {
                        maxValue = fromTail.Value;
                    }
                    fromRoot = fromRoot.Next;
                    if (fromRoot == fromTail)//NEED TO OPTIM
                    {
                        if (maxValue > fromRoot.Value)
                        {
                            maxValue = fromRoot.Value;
                        }
                        break;
                    }
                    fromTail = fromTail.Prev;
                    if (fromRoot == fromTail)
                    {
                        if (maxValue > fromTail.Value)
                        {
                            maxValue = fromTail.Value;
                        }
                        break;
                    }
                }
                return maxValue;
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public int FindIndexOfMaxContent()
        {
            int neededIndex;
            int index;
            int maxValue;

            neededIndex = 0;
            index = 0;
            DLNode tmp;
            DLNode tmp2;

            if (_root != null)
            {
                tmp = _root;
                tmp2 = _tail;
                maxValue = tmp.Value;
                while (tmp.Value != tmp2.Value)
                {
                    if (maxValue < tmp.Value)
                    {
                        maxValue = tmp.Value;
                        neededIndex = index;
                    }
                    if (maxValue < tmp2.Value)
                    {
                        maxValue = tmp2.Value;
                        neededIndex = Len - index - 1;
                    }
                    tmp = tmp.Next;
                    if (tmp == tmp2)//NEED TO OPTIM
                    {
                        if (maxValue < tmp.Value)
                        {
                            neededIndex = index + 1;
                        }
                        return neededIndex;
                    }
                    tmp2 = tmp2.Prev;
                    if (tmp == tmp2)
                    {
                        if (maxValue < tmp2.Value)
                        {
                            neededIndex = Len - index - 1;
                        }
                        return neededIndex;
                    }
                    index++;
                }
            }
            else
            {
                throw new Exception("List is empty");
            }

            return neededIndex;
        }

        public int FindIndexOfMinContent()
        {
            int neededIndex;
            int index;
            int minValue;

            neededIndex = 0;
            index = 0;
            DLNode tmp;
            DLNode tmp2;

            if (_root != null)
            {
                tmp = _root;
                tmp2 = _tail;
                minValue = tmp.Value;
                while (tmp.Value != tmp2.Value)
                {
                    if (minValue > tmp.Value)
                    {
                        minValue = tmp.Value;
                        neededIndex = index;
                    }
                    if (minValue > tmp2.Value)
                    {
                        minValue = tmp2.Value;
                        neededIndex = Len - index - 1;
                    }
                    tmp = tmp.Next;
                    if (tmp == tmp2)//NEED TO OPTIM
                    {
                        if (minValue > tmp.Value)
                        {
                            neededIndex = index + 1;
                        }
                        return neededIndex;
                    }
                    tmp2 = tmp2.Prev;
                    if (tmp == tmp2)
                    {
                        if (minValue > tmp2.Value)
                        {
                            neededIndex = Len - (index + 1) - 1;
                        }
                        return neededIndex;
                    }
                    index++;
                }
            }
            else
            {
                throw new Exception("List is empty");
            }

            return neededIndex;
        }
        #endregion

        #region SortingMethods
        public void SortByAscending()
        {
            LinkedList sryMax = new();
            Node sryAgain;
            DLNode newRoot;
            DLNode saveHead;
            if (_root != null)
            {
                while (_root != null)
                {
                    sryMax.AddFront(_root.Value);
                    _root = _root.Next;
                }
                sryMax.SortFromMinToMax();
                sryAgain = sryMax.GetRoot();
                newRoot = new(sryAgain.Value);
                saveHead = newRoot;
                while (sryAgain.Next != null)
                {
                    sryAgain = sryAgain.Next;
                    newRoot.Next = new(sryAgain.Value);
                    newRoot.Next.Prev = newRoot;
                    newRoot = newRoot.Next;
                }
                saveHead.Prev = null;
                _root = saveHead;
                while (saveHead.Next != null)
                {
                    saveHead = saveHead.Next;
                }
                _tail = saveHead;
            }

        }

        public void SortByDescending()
        {
            LinkedList sryMax = new();
            Node sryAgain;
            DLNode newRoot;
            DLNode saveHead;

            if (_root != null)
            {
                while (_root != null)
                {
                    sryMax.AddFront(_root.Value);
                    _root = _root.Next;
                }
                sryMax.SortFromMaxToMin();
                sryAgain = sryMax.GetRoot();
                newRoot = new(sryAgain.Value);
                saveHead = newRoot;
                while (sryAgain.Next != null)
                {
                    sryAgain = sryAgain.Next;
                    newRoot.Next = new(sryAgain.Value);
                    newRoot.Next.Prev = newRoot;
                    newRoot = newRoot.Next;
                }
                _root = saveHead;
                while (saveHead.Next != null)
                {
                    saveHead = saveHead.Next;
                }
                _tail = saveHead;
            }
        }
        #endregion

        public void DeleteOneByValue(int value)
        {
            DLNode tmp;

            if (_root != null)
            {
                if (_root.Value == value)
                {
                    _root = _root.Next;
                    if (_root != null)
                    {
                        _root.Prev = null;
                    }
                    return;
                }
                else if (_tail.Value == value)
                {
                    _tail = _tail.Prev;
                    _tail.Next = null;
                }
                else if (_root.Next == null)
                {
                    throw new Exception("Bad value");
                }
                else
                {
                    tmp = _root;
                    while (tmp != null && tmp.Value != value)
                    {
                        tmp = tmp.Next;
                    }
                    if (tmp == null)
                    {
                        throw new Exception("Bad value");
                    }
                    tmp.Next.Prev = tmp.Prev;
                    tmp.Prev.Next = tmp.Next;
                }
            }
            else
            {
                throw new Exception("List is empty");
            }
        }

        public int DeleteAllByValue(int value)
        {
            DLNode newList;
            DLNode saveHead;
            int cnt;

            cnt = 0;
            if (_root != null)
            {

                while (_root.Next != null && _root.Value == value)
                {
                    _root = _root.Next;
                    cnt++;
                }
                if (_root.Next == null)
                {
                    if (_root.Value == value)
                    {
                        _tail = null;
                        _root = null;
                        return cnt + 1;
                    }
                }
                newList = new(_root.Value);
                saveHead = newList;
                _root = _root.Next;
                while (_root != null)
                {
                    if (_root.Value != value)
                    {
                        newList.Next = new(_root.Value);
                        newList.Next.Prev = newList;
                        newList = newList.Next;
                    }
                    else
                    {
                        cnt++;
                    }
                    _tail = newList;
                    _root = _root.Next;
                }
                _root = saveHead;
                return cnt;
            }
            else
            {
                throw new Exception("List is empty");
            }
        }
        public void AddFront(DLList newList)
        {
            if (newList._root != null)
            {
                if (_root != null)
                {
                    _tail.Next = newList._root;
                    newList._root.Prev = _tail;
                    _tail = newList._tail;
                }
            }
            if (_root == null && newList._root != null)
            {
                _root = newList._root;
                _tail = newList._tail;
            }
            else if (newList._root == null)
            {
                return;
            }
        }
        public void AddBack(DLList newList)
        {
            if (_root == null)
            {
                _root = newList._root;
                _tail = newList._tail;
                return;
            }
            if (newList._root == null)
            {
                return;
            }
            newList._tail.Next = _root;
            _root.Prev = newList._tail;
            _root = newList._root;
            Len += newList.Len;
        }


        public void AddByIndex(DLList newList, int index)
        {
            DLNode tmp;
            DLNode tmp2;

            if (index < 0)
            {
                throw new Exception("you took bad index");
            }
            if (_root == null)
            {
                if (index == 0)
                {
                    AddFront(newList);
                    return;
                }
                throw new Exception("List is empty");
            }
            if (index > Len)
            {
                throw new Exception("you took bad index");
            }
            if (newList._root == null)
            {
                return;
            }
            tmp = _root;
            while (--index > 0)
            {
                tmp = tmp.Next;
            }
            tmp2 = tmp.Next;
            tmp.Next = newList._root;
            tmp.Next.Prev = tmp;
            tmp2.Prev = newList._tail;
            newList._tail.Next = tmp2;
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
            tmp1 = _tail;
            tmp2 = myNode._tail;
            while (tmp2 != null && tmp1 != null)
            {
                if ((tmp1.Prev == null && tmp2.Prev != null)
                || (tmp1.Prev != null && tmp2.Prev == null))
                {
                    return false;
                }
                if (tmp2.Value != tmp1.Value)
                {
                    return false;
                }
                tmp2 = tmp2.Prev;
                tmp1 = tmp1.Prev;
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

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        #endregion
        public void WriteTail()
        {
            DLNode tmp = _tail;

            while (tmp!=null)
            {
                Console.Write(tmp.Value + " ");
                tmp = tmp.Prev;
            }
            Console.WriteLine();

        }
    }
}

/* 
доступ по индексу написать сетгет
*/