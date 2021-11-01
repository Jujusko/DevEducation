using System;
using List;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = new int[] { 4, 5, 2, 6};
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
            a.DeleteAtEnd();
            a.AddFront(9);
            a.AddFront(45);
            a.WriteToConsole();
            a.AddOwnListAtByIndex(b, 1);
            a.WriteToConsole();
        }
    }
}
//0 1 22 44 5 2 984 7 8 9 45 
//0 1 22 44 2 984 7 8 9 45
