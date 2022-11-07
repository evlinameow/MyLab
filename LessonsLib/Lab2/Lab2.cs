using LessonsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab2
{
    internal class Lab2 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>    
        public void Demo()
        {
            Task1();
            Task2();
            Task3();
            Console.ReadKey();

            static void Task1()
            {
                Console.WriteLine("Задание 1");
                Console.WriteLine("Введите число");
                int number = 0;
                while (true)
                {
                    string str = Console.ReadLine();
                    bool res = int.TryParse(str, out number);
                    if (res == true)
                    {
                        if ((number >= 1) && (number <= 7))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Число за пределом диапазона");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введено не число");
                    }
                }
            }
            static void Task2()
            {
                Console.WriteLine("Задание 2");
                int number1 = 0;
                if ((number1 % 3 == 0) && (number1 % 5 == 0))
                    Console.WriteLine("BuzzFizz");
                else
                {
                    if (number1 % 3 == 0)
                        Console.WriteLine("Buzz");
                    else
                        if (number1 % 5 == 0)
                        Console.WriteLine("Fizz");
                }
            }
            static void Task3()
            {
                Console.WriteLine("Задача 3");
                Console.Write("Введите число 1: ");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите действие ");
                string action = Console.ReadLine();
                Console.Write("Введите число 2: ");
                double number2 = Convert.ToDouble(Console.ReadLine());
                double result = 0;
                switch (action)
                {
                    case "+":
                        result = number + number2;
                        break;
                    case "-":
                        result = number - number2;
                        break;
                    case "*":
                        result = number * number2;
                        break;
                    case "/":
                        result = number / number2;
                        break;
                    case "^":
                        result = Math.Pow(number, number2);
                        break;
                }
                Console.WriteLine($"{number} {action} {number2} = {result}");
            }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Лаба №2";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 2;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns>Тема лабы</returns>
        public string Title()
        {
            return "Лабораторная №2. Тема: Условия.Операторы сравнения";
        }
    }
}
