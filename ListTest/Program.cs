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

            //int[] a = new int[] { -23, -33, -123, -4444, 5555555 };
            //DLList test = new(a);
            //Console.WriteLine(test);
            //test.DeleteAllByValue(-95);
            //Console.WriteLine(test);
            //test.WriteTail();
            DLList aa = new DLList(new int[] { 1 ,2, 3});
            DLList add = new(new int[] { 4, 5 });
            Console.WriteLine(aa);
            aa.AddByIndex(add, 1);
            Console.WriteLine(aa);
            aa.WriteTail();
            BestList asa = new LinkedList(new int[] { 1, 2, 3, 4, 5});
            Console.WriteLine(asa);
        }
    }
}

