using LessonsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab4
{
    public class Lab4 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>  
        public void Demo()
        {

            Console.WriteLine("Задание 1");
            Task1();
            Console.WriteLine("Задание 2");
            Task2();
            Console.WriteLine("Задание 3");
            Task3();
            Console.ReadKey();

            static void Task1()
            {

                int n = 5;
                int[] mass = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rnd.Next(0, 100);
                    Console.WriteLine(mass[i] + "\t");
                }
            }
            static void Task2()
            {

                string str = "awd 23 f 4 rg3 3";
                string[] strArr = str.Split(' ');
                foreach (string el in strArr)
                {
                    Console.WriteLine(el);
                }
            }
            static void Task3()
            {

                int a = 5;
                int[] massBubble = new int[a];
                Console.WriteLine("числа для сортировки:");
                for (int g = 0; g < massBubble.Length; g++)
                {
                    Random rnd = new Random();
                    massBubble[g] = rnd.Next(0, 20);
                    Console.WriteLine(massBubble[g]);
                }
                BubbleSort(massBubble);
                Console.WriteLine("после сортировки:");
                for (int g = 0; g < massBubble.Length; g++)
                {
                    Console.WriteLine(massBubble[g]);
                }

                static int[] BubbleSort(int[] massBubble)
                {
                    int tmp;
                    for (int g = 0; g < massBubble.Length; g++)
                    {
                        for (int j = g + 1; j < massBubble.Length; j++)
                        {
                            if (massBubble[g] > massBubble[j])
                            {
                                tmp = massBubble[g];
                                massBubble[g] = massBubble[j];
                                massBubble[j] = tmp;
                            }
                        }
                    }
                    return massBubble;
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
            return "Лаба №4";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 4;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns>Тема лабы</returns>
        public string Title()
        {
            return "Лабораторная №4. Тема: Массивы.Строки";
        }
    }
}
