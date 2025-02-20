using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practic2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { "Milk", "Молоко" },
                { "Phone", "Телефон" },
                { "Black", "Черный" }
            };

            List<string> comands = new List<string>()
            {
                "1. Перевести слов",
                "2. Завершить игру"
                
            };

            int action = 0;

            while (action != 2)
            {
                Console.WriteLine("Введите команду: ");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        foreach (var translate in dictionary)
                        {
                            Console.WriteLine(translate);
                        }
                        Console.WriteLine("Введите слово на английском: ");
                        string s = Console.ReadLine();
                        if(dictionary.ContainsKey(s) == true)
                        {
                            dictionary.TryGetValue(s, out string ss);
                            Console.WriteLine($"Перевод слова {s} - {ss}");
                        }
                        else
                        {
                            Console.WriteLine("В нашем словаре такого слова нет");
                        }
                        

                        

                        break;
                }
            }
            

        }
    }
}
