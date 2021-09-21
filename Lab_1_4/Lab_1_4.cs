using System;

namespace Lab_1_4
{
    class Lab_1_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальное, а затем максимальное числа");
            int _min=Convert.ToInt32( Console.ReadLine());
            int _max=Convert.ToInt32( Console.ReadLine());

            int[,] arr = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Random rand = new Random();
                    arr[i,j] = rand.Next(_min, _max + 1);
                    Console.Write(arr[i,j] + "\t");
                }
                
                Console.Write("\n");
            }
        }
    }
}
