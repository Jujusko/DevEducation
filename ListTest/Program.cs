using System;
using List;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] k = new int[] { 0, 1, 2, 3, 5, 22 };
            ArrayList kkk = new ArrayList(k);
            ArrayList q = new ArrayList(k);
            q.WriteToConsole();
            kkk.WriteToConsole();
            kkk.DeleteAtHead();
            kkk.WriteToConsole();
        }
    }
}
//0 1 22 44 5 2 984 7 8 9 45 
//0 1 22 44 2 984 7 8 9 45
