using System;
using System.Collections.Generic;

namespace Lab_1_7
{
    class Lab_1_7
    {
        public struct Student
        {
            public string FIO;

            public int Math;
            public int Russian;
            public int English;
        }

        static void Main(string[] args)
        {
            Student[] arr = new Student[10];
            int index = 0;
            bool pr = true;
            while(pr)
            {
                Console.WriteLine("1. Ввести данные о новом студенте\n2.полный список студентов\n3. список студентов, имеющих только отличные оценки\n 4. список студентов, имеющих хотя бы одну неудовлетворительную оценку\n5. Закончить работу со списками");
                int _var = Convert.ToInt32(Console.ReadLine());
                switch (_var)
                {
                    case 1:
                        if (index < 10)
                        {


                            Console.WriteLine("Введите ФИО, а затем оценки по Математике, русскому и английскому");
                            arr[index] = F();
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("Нет места");
                        }
                        break;
                    case 2:
                        for (int i = 0; i < index; i++)
                        {
                            Student item = arr[i];
                            Console.WriteLine(item.FIO + "\nМатематика: " + item.Math + "\nРУсский: " + item.Russian + "\nАнглийский: " + item.English);
                        }
                        break;
                    case 3:
                        foreach (var item in arr)
                        {
                            if(item.English==5 && item.Math==5 && item.Russian==5)
                            {
                                Console.WriteLine(item.FIO);
                            }

                        }
                        break;
                    case 4:
                        foreach (var item in arr)
                        {
                            if(item.English==2 || item.Math==2 || item.Russian==2)
                            {
                                Console.WriteLine(item.FIO);
                            }
                        }
                        break;
                    case 5:
                        pr=!pr;
                        break;
                    
                }

            }
        }

        static Student F()
        {
            Student stud = new Student();

            stud.FIO = Console.ReadLine();
            stud.Math = Convert.ToInt32(Console.ReadLine());
            stud.Russian= Convert.ToInt32(Console.ReadLine());
            stud.English= Convert.ToInt32(Console.ReadLine());
            return stud;
        }
    }
}
