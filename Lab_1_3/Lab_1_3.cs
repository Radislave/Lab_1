using System;

namespace Lab_1_3
{
    class Lab_1_3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            F(ref a,ref b);
            Console.WriteLine("Число а: " + a + "\nЧисло b: " + b);
        }

        static void F(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
