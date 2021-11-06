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
            while (tmp.Next.Index != index)
            {
                tmp = tmp.Next;
            }
            tmp2 = tmp.Next.Next;
            tmp.Next = tmp2;
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

            tmp1 = _root;
            tmp2 = _root.Next;
            tmp3 = _root.Next.Next;
            tmp1.Next = null;
            while (tmp2.Next != null)
            {
                tmp2.Next = tmp1;//2 на 1 .. 5 na 4
                //Console.WriteLine("теперь индекс " + tmp2.Index + " указывает на "+ tmp1.Index);
                //Console.Write("теперь индекс " + tmp1.Index);
                tmp1 = tmp3.Next;//now 4 .. now 7
                if (tmp3.Next == null)
                {
                    tmp3.Next = tmp2;
                   // Console.WriteLine(tmp3.Value + " " + tmp2.Value + " ");
                    _root = tmp3;
                    break;
                }
                    //Console.WriteLine(" равен  " + tmp3.Next.Index);
                tmp3.Next = tmp2;//3 na 2 .. 6 na 5
                //Console.WriteLine("теперь индекс " + tmp3.Index + " указывает на  " + tmp2.Index);
                //Console.Write("теперь индекс " + tmp2.Index);
                tmp2 = tmp1.Next;//now 5 .. 
                if (tmp1.Next == null)
                {
                    tmp1.Next = tmp3;
                    //Console.WriteLine(tmp1.Value + " " + tmp3.Value + " ");
                    _root = tmp1;
                    break;
                }
                //Console.WriteLine(" равен  " + tmp1.Next.Index);
                tmp1.Next = tmp3;//4 na 3
                //Console.WriteLine("теперь индекс " + tmp1.Index + " указывает на   " + tmp3.Index);
                //Console.Write("теперь индекс " + tmp3.Index);
                tmp3 = tmp2.Next;//now 6
                if (tmp2.Next == null)
                {
                   // Console.WriteLine(tmp1.Value + " " + tmp2.Value + " ");
                    tmp2.Next = tmp1;
                    _root = tmp2;
                    break;
                }
                //Console.WriteLine(" равен  " + tmp2.Next.Index);
            }
            
        }

        public Node GetMaxContent()
        {
            Node neededNode;
            Node tmp;

            tmp = _root;
            neededNode = null;
            while (tmp.Next != null)
            {
                if (tmp.Value < tmp.Next.Value)
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
            neededNode = null;
            while (tmp.Next != null)
            {
                if (tmp.Value > tmp.Next.Value)
                    neededNode = tmp;
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
    }
}
