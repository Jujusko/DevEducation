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

            Node a = new Node(12);
            LinkedList lisst = new LinkedList(1);
            lisst.DeleteOneNodeByContent(1);
            lisst.WriteContent();
            lisst.WriteContent();
            lisst.AddFront(2);
            lisst.AddFront(3);
            lisst.AddFront(4);
            lisst.AddFront(5);
            lisst.AddFront(11);
            lisst.AddFront(4);
            lisst.AddBack(-1);
            lisst.WriteContent();
            int[] ass = new int[] { 1, 2, 3, 5, 22 };
            LinkedList gl = new LinkedList(ass);
            LinkedList ww = new LinkedList(ass);
            gl.AddByIndex(2, 0);
            gl.WriteContent();
            Console.WriteLine("hello");
            //Console.WriteLine(lisst.GetIndexByContent(5));
        }
    }
}

