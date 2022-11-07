using LessonsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab1
{
    public class Lab1 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>
        public void Demo()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadKey();

            static void Task1()
            {
                Console.WriteLine("Задача 1");
                double a = Math.Pow(2, 2) - Math.Pow(3, 3);
                double b = Math.Sqrt(Math.Pow(3, 4) - Math.Pow(2, 4));
                double c = Math.Abs(Math.Pow(3, 5) - Math.Pow(15, 2.5));
                double d = Math.Sqrt(a / b + c);
                Console.WriteLine(d);
            }
            static void Task2()
            {
                Console.WriteLine("Задача 2");
                Random rnd = new Random();
                double e = rnd.Next(-10, 10);
                double f = rnd.Next(-10, 10);
                double h = (Math.Pow(e, 2) + Math.Pow(f, 1 / 3)) / (e + f);
                Console.WriteLine($"e={e},f={f}, результат:{h}");

            }
            static void Task3()
            {
                Console.WriteLine("Задача 3");
                double w = 5.93576;
                int m = (int)w;
                Console.WriteLine("int b = (int)a = " + m);
                int x = (int)Math.Round(w);
                Console.WriteLine("int c = Math.Round(a) = " + x);
                int l = (int)Math.Floor(w);
                Console.WriteLine("int d = MAth.Floor(a) = " + l);
                double z = Math.Round(w, 1);
                Console.WriteLine("double e = Math.Round(a) = " + z);
                int g = 5;
                Console.WriteLine("int f = 5; int g = f++; = " + g++);
                Console.WriteLine("int f = 5; int g = f++; = " + ++g);

            }
            static void Task4()
            {
                Console.WriteLine("Задача 4");
                Random rnd = new Random();
                double r = rnd.NextDouble();
                Console.WriteLine(r);
            }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Лаба №1";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 1;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns>Тема лабы</returns>
        public string Title()
        {
            return "Лабораторная №1. Тема: Арифметические операции. Классы Random и Math. Приведение числовых типов данных. Округление. Суффиксы и префиксы";
        }
    }
}
