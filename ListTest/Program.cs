using System;
using List;
using Nodes;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Node a = new Node(12);
            LinkedList lisst = new LinkedList(1);
            lisst.WriteContent();
            lisst.AddFront(2);
            lisst.AddFront(3);
            lisst.AddFront(4);
            lisst.AddFront(5);
            lisst.AddFront(11);
            lisst.AddFront(4);
            lisst.AddBack(-1);
            lisst.WriteContent();
            lisst.AddByIndex(1, 999);
            lisst.WriteContent();
            lisst.DeleteSomeElementsFromNeededIndex(2,2);
            lisst.WriteContent();
            lisst.ReverseList();
            lisst.WriteContent();
            lisst.SortFromMinToMax();
            lisst.WriteContent();
            Console.WriteLine("OK");
            lisst.SortFromMaxToMin();
            lisst.ReverseList();
            lisst.WriteContent();

            LinkedList aaa = new LinkedList();
            Console.WriteLine(aaa);
            lisst.WriteContent();
            Console.WriteLine(lisst);
            //Console.WriteLine(lisst.GetIndexByContent(5));
        }
    }
}

