﻿using System;

namespace Lab_1_6
{
    class Lab_1_6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер месяца");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && a < 3 || a == 12)
            {
                Console.WriteLine("Зима");
            }
            else if (a > 2 && a < 6)
            {
                Console.WriteLine("Весна");
            }
            else if (a > 5 && a < 9)
            {
                Console.WriteLine("Лето");
            }
            else if (a > 8 && a < 12)
            {
                Console.WriteLine("Осень");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
