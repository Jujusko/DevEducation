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

            int[] a = new int[] { 1, 2, 3, 4, 5, 6};
            DLList test = new(a);
            Console.WriteLine(test);
            test.SortByAscending();
            Console.WriteLine(test);
            test.WriteTail();
        }
    }
}

