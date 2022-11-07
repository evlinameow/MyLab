using LessonsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab7
{
    /// <summary>
    /// Метод демонстрации всех заданий лабораторной работы
    /// </summary> 
    public class Lab7 : ILabs
    {
        public void Demo()
        {
            Group PCS20 = new Group();
            PCS20.Add(new Student("Алина_Якова", 18, "женский", "PCS20", "ВКУиНТ", "Техник-программист"));
            PCS20.Add(new Student("Виктор_Фомин", 17, "мужской", "PCS20", "ВКУиНТ", "Техник-программист"));
            PCS20.Add(new Student("Виктория_Наядова", 18, "женский", "PCS20", "ВКУиНТ", "Техник-программист"));
            PCS20.Add(new Student("Сергей_Петренко", 19, "мужской", "PCS20", "ВКУиНТ", "Техник-программист"));
            PCS20.Add(new Student("Ирина_Матроскина", 20, "женский", "PCS20", "ВКУиНТ", "Техник-программист"));
            PCS20.Add(new Student("Максим_Романенко", 17, "мужской", "PCS20", "ВКУиНТ", "Техник-программист"));
            PCS20.Add(new Student("Елизавета_Завьялова", 19, "женский", "PCS20", "ВКУиНТ", "Техник-программист"));
            PCS20.Add(new Student("Леонид_Морозов", 20, "мужской", "PCS20", "ВКУиНТ", "Техник-программист"));
            PCS20.Add(new Student("Екатерина_Рядова", 18, "женский", "PCS20", "ВКУиНТ", "Техник-программист"));
            PCS20.Add(new Student("Михаил_Бубнов", 18, "мужской", "PCS20", "ВКУиНТ", "Техник-программист"));

            PCS20.PrintGroup();

            var jsonFormatter = new DataContractSerializer(typeof(Group));
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, PCS20);
            }
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                var newStudent = jsonFormatter.ReadObject(file) as List<Student>;
                if (newStudent != null)
                {
                    foreach (var student in newStudent)
                    {
                        Console.WriteLine(student);
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
            return "Лаба №7";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 7;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns>Тема лабы</returns>
        public string Title()
        {
            return "Лабораторная №7. Тема: Серализация";
        }
    }
}
