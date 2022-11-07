using LessonsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab3
{
    public class Lab3 : ILabs
    {
        public void Demo()
        {
            Task1();
            Task2();
            Console.ReadKey();

            static void Task1()
            {
                Console.WriteLine("Задание 1");
                int i = 0;
                while (i < 100)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
                for (i = 0; i < 100; i++)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                i = 0;
                do
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
                while (i < 100);
            }
            static void Task2()
            {
                Console.WriteLine("Задание 2");
                int a = 0;
                while (a < 30)
                {
                    if (a % 2 == 0)
                    {
                        Console.WriteLine(a);
                    }
                    a++;
                }
            }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Лаба №3";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 3;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns>Тема лабы</returns>
        public string Title()
        {
            return "Лабораторная №3. Тема: Циклы";
        }
    }
}
