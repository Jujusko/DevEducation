using System;

namespace DevEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            int              i, j;
            int[]            arr;
            /*
            int              neededValue = 0;
            (int, int)       needInts;
            (double, double) needDoubles;
            string           toReturn;
            */
            dynamic          gates = 1;
            int cnt;
            Console.WriteLine("Choose correct day");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose task");
            j = Convert.ToInt32(Console.ReadLine());
            gates = Manager.ManageTasks(i, j);
            /*
            i = 2;dsds
            while (i < 4)
            {
                j = 1;
                while (j <= 12)
                {
                    if (gates is int)
                        if (gates == -1)
                        {
                            j = 1;
                            i++;
                        }
                    gates = Manager.ManageTasks(i, j);
                    if (gates is int[])
                    {
                        cnt = 0;
                        arr = gates;
                        while (cnt < arr.Length)
                            Console.Write(arr[cnt++] + " ");
                    }
                    else
                        Console.WriteLine(gates);
                    j++;
                }
                i++;
            }
            */
        }
    }
}
