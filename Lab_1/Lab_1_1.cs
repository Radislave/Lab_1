using System;

namespace Lab_1
{
    class Lab_1_1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if(i*j<10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(i * j+" ");
                }
                Console.Write("\n");
            }
        }
    }
}
