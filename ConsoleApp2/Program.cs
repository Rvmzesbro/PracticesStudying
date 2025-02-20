using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> Rules = new List<string>()
            {

                "1. Добавить новое заклинание в список, нельзя добавлять одинаковые.",
                "2. Добавить сразу несколько изученных заклинаний (Бурлящая Ярость, Окаменевший Взгляд, Магический Панцирь).",
                "3. Удалить заклинание по имени.",
                "4. Изменить существующее заклинание.",
                "5. Посмотреть список всех доступных заклинаний.",
                "6. Ограничьте максимальное количество заклинаний (например, 10).",
                "7. Найдите все заклинания начинающиеся на М.",
                "8. Добавьте возможность использовать заклинания в бою, удаляя их из списка при использовании, брать первое попавшееся заклинание.",
                "9. После боя проверить сколько заклинаний осталось для защиты.",
                "10. В вашей школе наступил запрет на заклинания для боя, удалить все заклинания начинающиеся на Б.",
                "11. Завершить игру."
            };

            foreach (string Rule in Rules)
            {
                Console.WriteLine(Rule);
            }

            List<string> Spells = new List<string>()
            {
                "Морозный Барьер",
                "Озорной Звук",
                "Мерцающая Завеса",
                "Молния Отражения",
                "Бешеная Лавина",
                "Огуречное Превращение",
                "Буря Камней",

            };

            int action = 0;
            while (action != 11)
            {
                Console.WriteLine("Введите команду: ");
                action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:

                        Console.WriteLine("Введите заклинание: ");
                        string z = Console.ReadLine();
                        if (Spells.Contains(z))
                        {
                            Console.WriteLine("Такое заклинание есть");
                        }
                        else
                        {
                            if (Spells.Count <= 10)
                            {
                                Spells.Add(z);
                            }

                        }


                        foreach (string Spell in Spells)
                        {
                            Console.WriteLine(Spell);
                        }



                        break;

                    case 2:
                        Console.WriteLine("Сколько заклинаний хотите добавить?");
                        int x = Convert.ToInt32(Console.ReadLine());
                        if ((Spells.Count + x) <= 10)
                        {
                            for (int d = 0; d < x; d++)
                            {

                                Console.WriteLine("Введите заклинания которые хотите добавить: ");
                                Spells.Add(Console.ReadLine());

                            }
                        }

                        foreach (string Spell in Spells)
                        {
                            Console.WriteLine(Spell);
                        }

                        break;


                    case 3:

                        Spells.Remove(Console.ReadLine());

                        break;

                    case 4:

                        Console.WriteLine("Введите заклинание которое хотите изменить");
                        string a = Console.ReadLine();
                        Console.WriteLine("Введите новое заклинание");
                        string p = Console.ReadLine();

                        for (int i = 0; i < Spells.Count; i++)
                        {
                            if (Spells[i] == a)
                            {
                                Spells[i] = p;
                            }
                        }

                        break;

                    case 5:

                        foreach (string Spell in Spells)
                        {
                            Console.WriteLine(Spell);
                        }

                        break;

                    case 6:

                        Console.WriteLine("Ограничение 10 заклинаний");

                        break;

                    case 7:

                        foreach (string Spell in Spells)
                        {
                            if (Spell.StartsWith("М"))
                            {
                                Console.WriteLine(Spell);
                            }
                        }

                        break;

                    case 8:

                        foreach (string Spell in Spells)
                        {
                            Console.WriteLine(Spell);
                        }

                        Console.WriteLine("Какое заклинание хотите использовать?");
                        string f = Console.ReadLine();

                        for (int i = 0; i < Spells.Count; i++)
                        {
                            Spells.Remove(f);
                        }

                        foreach (string Spell in Spells)
                        {
                            Console.WriteLine(Spell);
                        }


                        break;

                    case 9:

                        int count = 0;
                        foreach (string Spell in Spells)
                        {
                            if (Spell.StartsWith("М"))
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"Осталось {count} заклинания");
                        break;

                    case 10:
                        Spells.RemoveAll(o => o.StartsWith("Б"));
                        foreach (string Spell in Spells)
                        {
                            Console.WriteLine(Spell);
                        }

                        break;
                }
            }
            }

          


    }

}
    

