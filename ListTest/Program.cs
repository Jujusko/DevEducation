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

            int[] a = new int[] { 1, 2, 3, 4, 5 };
            DLList test = new(a);
            Console.WriteLine(test);
            test.AddFront(555);
            Console.WriteLine(test);
            test.AddBack(999);
            Console.WriteLine(test);
            test.AddByIndex(6, 100);
            Console.WriteLine(test);
        }
    }
}

