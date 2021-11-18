using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    public abstract class BestList
    {
       
        public abstract void AddFront<T>(T value);
        public abstract void AddBack(int value);

        public abstract void AddByIndex(int index, int value);
        public abstract void DeleteFromEnd();
        public abstract void DeleteAtHead();

        public abstract void DeleteByIndex(int index);

        public abstract void DeleteSomeElementsFromEnd(int amount);
        public abstract void DeleteSomeElementsFromHead(int amount);

        public abstract void DeleteSomeElementsFromNeededIndex(int index, int amount);

        public abstract int GetLenght();

        public abstract int DeleteOneNodeByContent(int value);

        public abstract int DeleteAllNodesWithSameContent(int value);

        public abstract int GetValueByIndex(int index);

        public abstract int GetIndexByContent(int content);
        public abstract void SetContentByIndex(int index, int value);
        public abstract void ReverseList();
        public abstract int GetMaxContent();
        public abstract int GetMinContent();
        public abstract int GetMaxContentIndex();
        public abstract int GetMinContentIndex();
        public abstract void SortFromMinToMax();
        public abstract void SortFromMaxToMin();
    }
}
