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
            int[] a = Debug1.GetNumbersWhereSumOfEvenDigitsGreaterThanOddDigits(40);
            int i = 0;
            while(i < a.Length)
            {
                Console.Write(a[i] + " ");
                i++;
            }
        }
      
    }
}
