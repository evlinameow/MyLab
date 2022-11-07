using LessonsInterface;
using System.Reflection;

namespace Labs;

class Program
{
    private static List<ILabs> _labs = new List<ILabs>();
    /// <summary>
    /// Метод получения списка лабараторных из dll библиотеки классов
    /// </summary>
    private static void LoadILabsList()
    {
        Assembly asm = Assembly.LoadFrom("LessonsLib.dll"); //создание сборки из библиотеки классов
        Type[] types = asm.GetTypes();      //выгрузка классов в массив
        foreach (Type type in types)    //перебираем классы и интерфейсы
        {
            if ((type.IsInterface == false) && (type.IsAbstract == false))  //не добавляем абстрактные классы и интерфейсы
            {
                foreach (var method in type.GetMethods())    //перебираем методы класса
                {
                    if (method.ToString().Contains("Demo")) //если среди методов класса содержится Demo
                    {
                        ILabs labs = (ILabs)Activator.CreateInstance(type);
                        _labs.Add(labs);    //подгружаем этот класс в список лабараторных
                    }
                }
            }
        }
    }

    static void Main()
    {
        LoadILabsList();
        _labs.Reverse();
        LabsInfo(_labs);                 // выводим информацию о всех лабах

        bool running = true;

        while (running)                // запускаем бесконечный цикл
        {
            Console.Write("Введите ID лабораторной: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "clear":
                    Clear();
                    break;
                case "info":
                    LabsInfo(_labs);
                    break;
                case "help":
                    Help();
                    break;
                case "exit":
                    running = false;
                    break;
                default:
                    {
                        Demo(_labs, command);
                    }
                    break;
            }
        }
    }

    /// <summary>
    /// Метод запускает Demo по введенному ID
    /// </summary>
    /// <param name="labs"></param>
    /// <param name="id"></param>
    static void Demo(List<ILabs> labs, string id)
    {
        try
        {
            int ID = Convert.ToInt32(id);
            foreach (ILabs lab in labs)
            {
                if (ID == lab.Id())
                {
                    lab.Demo();
                }
            }
        }
        catch
        {
            Console.WriteLine("Неверная команда. Попробуйте еще раз.");
        }
    }

    /// <summary>
    /// Метод выводит информацию обо всех доступных лабораторных
    /// </summary>
    /// <param name="labs"></param>
    static void LabsInfo(List<ILabs> labs)
    {
        foreach (ILabs lab in labs)
        {
            Console.WriteLine(lab.Id());
            Console.WriteLine(lab.Title());
            Console.WriteLine(lab.Description());
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Метод очищает экран
    /// </summary>
    static void Clear()
    {
        Console.Clear();
    }

    /// <summary>
    /// Метод выводит все доступные команды
    /// </summary>
    static void Help()
    {
        string[] commands =
        {
            "<ID> - запуск демонстрации лабораторной по ID",
            "<exit> - выход",
            "<help> - список доступных команд",
            "<clear> - очистка экрана",
            "<info> - вывод информации о всех лабораторных"
        };

        foreach (string command in commands)
        {
            Console.WriteLine(command);
        }
    }
}
