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

            int[] a = new int[] { -455, 123,-1, -32, -123, 1, 0, 1234, -1000 };
            DLList test = new(a);
            Console.WriteLine(test);
            test.DeleteOneByValue(123);
            Console.WriteLine(test);
        }
    }
}

