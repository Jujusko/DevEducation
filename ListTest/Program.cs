using System;
using List;
using System.Linq;
using Nodes;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Node a = new Node(12);
            //LinkedList lisst = new LinkedList(1);
            //lisst.DeleteOneNodeByContent(1);
            //lisst.WriteContent();
            //lisst.WriteContent();
            //lisst.AddFront(2);
            //lisst.AddFront(3);
            //lisst.AddFront(4);
            //lisst.AddFront(5);
            //lisst.AddFront(11);
            //lisst.AddFront(4);
            //lisst.AddBack(4);
            //lisst.AddFront(1);
            //lisst.WriteContent();
            //lisst.DeleteAllNodesWithSameContent(4);
            //lisst.WriteContent();
            //LinkedList wer = new LinkedList(new int[10] { 1, 2, 3, 5, 22, -23, 45, 333, -12345, 0 });
            //wer.WriteContent();
            //int s = wer.GetMinContentIndex();
            //Console.WriteLine(s);

            ArrayList abc = new(new int[] { 1, 1, 1, 1, 1, 1, 1 });
            Console.WriteLine(abc);
            int c = abc.DeleteAllElemsWithGivenContent(1);
            Console.WriteLine(c);
            //Console.WriteLine(lisst.GetIndexByContent(5));
        }
    }
}

