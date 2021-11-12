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
                    if (steps == 1)
                    {
                        AddBack(value);
                    }
                    else
                    {
                        tmp = _tail;
                        while (steps-- != 0)
                        {
                            tmp = tmp.Prev;
                        }
                        createdNode.Prev = tmp.Prev;
                        createdNode.Next = tmp.Next;
                        tmp.Next = createdNode;
                        tmp.Prev = createdNode.Prev.Prev;
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
                _tail.Next = null;
                Len--;
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

                    while (--index != 0)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next.Prev = tmp.Prev;
                    tmp.Next = tmp.Next.Next;
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
                throw new ArgumentException($"Too big Lists to delete, it should being less than {Len}");
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
        }// NOTESTS
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
    доступ по индексу написать сетгет
    первый индекс по значению
    изменение по индексу
    реверс (123 -> 321)
    поиск значения максимального элемента
    поиск значения минимального элемента
    поиск индекс максимального элемента
*/