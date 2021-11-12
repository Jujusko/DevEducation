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

            int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            DLList test = new(a);
            Console.WriteLine(test);
            test.DeleteByIndexSomeElems(0,2);
            Console.WriteLine(test);
        }
    }
}

