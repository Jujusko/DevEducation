using System;
using List;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List.ArrayList a = new ArrayList();
            a.AddFront(0);
            a.AddFront(1);
            a.AddFront(22);
            a.AddFront(44);
            a.AddFront(5);
            a.AddFront(2);
            a.AddFront(984);
            a.AddFront(7);
            a.AddFront(8);
            a.AddFront(9);
            a.AddFront(45);
            a.WriteToConsole();
            a.DeleteFirstElemByContent(5);
            a.WriteToConsole();
        }
    }
}
