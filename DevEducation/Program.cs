using System;

namespace DevEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            /*
            Console.WriteLine("Choose correct day");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose task");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Manager.ManageTasks(i, j));
            */
            int []array = Arrays.SomeSorts.SelectSort();
            int cnt = 0;
          
            //Console.WriteLine(" ",Arrays.PartTwo.ChangeArrayHalves());
        }
    }
}
