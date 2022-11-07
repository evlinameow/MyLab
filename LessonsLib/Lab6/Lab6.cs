using LessonsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab6
{
    public class Lab6 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>  
        public void Demo()
        {
            Console.WriteLine("Задание 1");
            Task1();
            Task2();
            Console.ReadKey();

            static void Task1()
            {
                int n = 5;
                Console.WriteLine(Factorial(n));
            }
            static int Factorial(int n)
            {
                if (n == 1)
                    return 1;
                return n * Factorial(n - 1);
            }
            static void Task2()
            {
                int Fibonachi(int n)
                {
                    if (n == 0 || n == 1)
                        return n;
                    return Fibonachi(n - 1) + Fibonachi(n - 2);
                }
                int a = Fibonachi(6);
                int b = Fibonachi(7);
                int c = Fibonachi(8);
                int d = Fibonachi(9);
                int f = Fibonachi(10);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine(f);
            }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Лаба №6";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 6;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns>Тема лабы</returns>
        public string Title()
        {
            return "Лабораторная №6. Тема: Рекурсивная функция";
        }
    }
}
