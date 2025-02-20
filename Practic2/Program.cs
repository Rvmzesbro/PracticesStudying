using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> comands = new List<string>()
            {
                "1. Добавить контакт",
                "2. Удалить контакт по имени",
                "3. Изменить номер контакта", 
                "4. Искать контакта по имени",
                "5. Искать контакт по номеру",
                "6. Просмотреть все контакты",
                "7. Завершить игру"
            };
            foreach (var com in comands)
            {
                Console.WriteLine(com);
            }

            Dictionary<string, string> contacts = new Dictionary<string, string>()
            {

            };

            int action = 0;
            while(action != 7)
            {
                Console.WriteLine("Введите команду: ");
                action = int.Parse(Console.ReadLine());

                

                switch (action)
                {
                    case 1:
                        Console.Write("Введите имя: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите номер: ");
                        string phone = Console.ReadLine();
                        contacts.Add(name, phone);
                        foreach(var contact in contacts)
                        {
                            Console.WriteLine(contact);
                        }
                        break;
                    case 2:
                        foreach(var contact in contacts)
                        {
                            Console.WriteLine(contact);
                        }
                        Console.Write("Введите имя контакта, которого хотите удалить: ");
                        string x = Console.ReadLine();
                        contacts.Remove(x);
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine(contact);
                        }
                        break;
                    case 3:
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine(contact);
                        }
                        Console.WriteLine("Введите имя контакта, номер которого хотите изменить");
                        string a = Console.ReadLine();
                        Console.WriteLine("Введите новый номер телефона: ");
                        string newPhone1 = Console.ReadLine();
                        contacts[a] = newPhone1;
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine(contact);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите имя контакта");
                        string s = Console.ReadLine();
                        contacts.ContainsKey(s);
                        Console.WriteLine(contacts[s]);
                        break;
                    case 5:
                        Console.WriteLine("Введите номер контакта");
                        string d = Console.ReadLine();
                        contacts.ContainsValue(d);
                        var contact1= contacts.FirstOrDefault(p => p.Value== d);
                        Console.WriteLine(contact1);

                        break;
                    case 6:
                        foreach( var contact in contacts)
                        {
                            Console.WriteLine(contact);
                        }
                        break;
                }
            }
        }
    }
}
