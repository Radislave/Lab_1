using System;

namespace Lab_1_5
{
    class Lab_1_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int ch=Convert.ToInt32( Console.ReadLine());

            

            if(!F(ch))
            {
                for (int i = 2; i <= ch; i++)
                {
                    if(!F(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Не является простым числом");
            }
        }

        static bool F(int a)
        {
            bool pr = false;
            for (int i = 2; i < a; i++)
            {
                if(a%i==0)
                {
                    pr = true;
                }
            }
            return pr;
        }
    }
}
