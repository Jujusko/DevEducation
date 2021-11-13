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

            int[] a = new int[] { 111, 222, 333 };
            int[] b = new int[] {1, 2, 3 };
            DLList test = new(a);
            DLList ttt = new(b);
            Console.WriteLine(test);
            test.AddByIndex(ttt, 1);
            Console.WriteLine(test);
        }
    }
}

