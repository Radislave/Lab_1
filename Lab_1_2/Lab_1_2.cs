using System;

namespace Lab_1_2
{
    class Lab_1_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            if (char.IsDigit(Convert.ToChar( Console.ReadLine())))
            {
                Console.WriteLine("Цифра");
            }
            else
            {
                Console.WriteLine("Не цифра");
            }
        }
    }
}
