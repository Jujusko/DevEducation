using System;

namespace DevEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            //  First task
            /*
            int i, j;
            Console.WriteLine("Choose correct day");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose task (from 1 to 5)");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Manager.ManageTasks(i, j));
            */
            Console.WriteLine(Loops.Dubs.FindDubs());
        }
    }
}
