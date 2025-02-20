using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> comands = new List<string>()
            {
                "1. Сохраняет имена студентов и их оценки в словаре",
                "2. Позволяет добавлять результаты экзаменов",
                "3. Выводит список студентов и их оценок",
                "4. Подсчет и вывод среднего балла",
                "5. Подсчет и вывод абсолютной и качественной успеваемости",
                "6. Завершить игру"
            };
            foreach(var com in comands)
            {
                Console.WriteLine(com);
            }

            Dictionary<string, int> students = new Dictionary<string, int>()
            {

            };

            int action = 0;
            while (action != 6)
            {
                Console.WriteLine("Введите команду: ");
                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        Console.Write("Введите имя студента, которого хотите сохранить: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите оценку студента, которую хотите сохранить: ");
                        int grade = int.Parse(Console.ReadLine());
                        students.Add(name, grade);
                        foreach (var student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;

                    case 2:
                        Console.Write("Введите имя студента: ");
                        string name1 = Console.ReadLine();
                        Console.Write("Введите результат студента: ");
                        int grade1 = int.Parse(Console.ReadLine());
                        students.Add(name1, grade1);
                        foreach (var student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case 3:
                        foreach(var student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case 4:
                        double count = students.Count();
                        double sum = 0;
                        foreach(var grades in students.Values)
                        {
                            sum += grades;
                            
                        }
                        double d = sum/ count;
                        Math.Round(d, 2);
                        Console.WriteLine(d);

                        break;
                    case 5:
                        double count1 = students.Count();
                        double sum1 = 0;
                        double five = 0;
                        double four = 0;
                        double three = 0;
                        int countnum = students.Values.Where(x => x < 5 && x > 2).Count();
                        foreach(var grades in students.Values)
                        {
                            if (grades == 5)
                            {
                                five += 1;
                            }
                            else if(grades == 4)
                            {
                                four += 1;
                            }
                            else
                            {
                                three += 1;
                            }
                            
                        }
                        double f = (five + four + three)/ count1;
                        Console.WriteLine($"Абсолютная успеваемость: {Math.Round(f,2)}");

                        double sum2 = 0;
                        double five1 = 0;
                        double four1 = 0;
                        foreach (var grades in students.Values)
                        {
                            if (grades == 5)
                            {
                                five1 += 1;
                            }
                            else if (grades == 4)
                            {
                                four1 += 1;
                            }

                        }
                        double w = (five1 + four1)/ count1;
                        Console.WriteLine($"Качественная успеваемость: {Math.Round(w, 2)}");
                        break;
                }
            }

        }
    }
}
