using System;

namespace DevEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Настолько заморочился с менеджером задач, что он решил удалиться от всего ужаса
            // Если будет нужно, для простоты можно написать тестер какой-нибудь
            // с рандомными кейсами, если еще и ввести стандарт на название прототипов,
            // то хоть для всей группы сделать можно
            //int a = Loops.Fibonacci.FindFiboByIndex(0);

           int[,] actual = new int[6,3];
            int i = 0;
            int j = 0;
            Random r = new();
            Console.WriteLine("{");
            while (i < actual.GetLength(0))
            {
                Console.Write("{ ");
                j = 0;
                while (j < actual.GetLength(1))
                {
                    actual[i, j] = r.Next(2,2);
                    Console.Write(actual[i, j] + ", ");
                    j++;
                }
                Console.WriteLine("},");
                i++;
            }
            Console.WriteLine("}");
        }

    }
}
