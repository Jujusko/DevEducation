﻿using System;

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
            int a = Loops.Fibonacci.FindFiboByIndex(0);
            Console.WriteLine(a);
        }
      
    }
}
