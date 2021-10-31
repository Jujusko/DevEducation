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

            int[] actual = Arrays.SomeSorts.SelectSort(new int[10] { 83, 75, 74, 86, 23, 67, 85, 64, 45, 40 });
            int cnt = 0;
            while(cnt < actual.Length)
            {
                Console.Write(actual[cnt] + ", ");
                cnt++;
            }
        }

    }
}
