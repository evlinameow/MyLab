using LessonsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab5
{
    public class Lab5 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>  
        public void Demo()
        {
            Console.WriteLine("Задание 1");
            Task1();
            Console.ReadKey();

            static void Task1()
            {
                int n = 4;
                int[,] mass = RandomMatrix(n);
                PrintMatrix(mass);
                Console.WriteLine(MassSumma(mass));
                Dioganal1(mass);
                Console.WriteLine();
                Dioganal2(mass);
                Console.ReadKey();

                static int[,] RandomMatrix(int n)
                {
                    int[,] mass = new int[n, n];
                    Random rnd = new Random();
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        for (int j = 0; j < mass.GetLength(1); j++)
                        {
                            mass[i, j] = rnd.Next(-50, 50);
                        }
                    }
                    return mass;
                }
                static void PrintMatrix(int[,] mass)
                {
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        for (int j = 0; j < mass.GetLength(1); j++)
                        {
                            Console.Write(mass[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                static int MassSumma(int[,] mass)
                {
                    int summa = 0;
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        for (int j = 0; j < mass.GetLength(1); j++)
                        {
                            summa += mass[i, j];
                        }
                    }
                    return summa;
                }
                static void Dioganal1(int[,] mass)
                {
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        Console.Write(mass[i, i] + "\t");
                    }
                }
                static void Dioganal2(int[,] mass)
                {
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        Console.Write(mass[i, mass.GetLength(0) - i - 1] + "\t");
                    }
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
            return "Лаба №5";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 5;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns>Тема лабы</returns>
        public string Title()
        {
            return "Лабораторная №5. Тема: Двумерные массивы";
        }
    }
}
