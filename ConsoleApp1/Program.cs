using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = "";
            List<string> Sotrudniki = new List<string>() { "Петров Петр Петрович", "Иванов Иван Иванович" };
            while (action != "End")
            {
                Console.WriteLine("Введите команду: ");
                action = Console.ReadLine();
                
                
                switch (action)
                {
                    case "Add":


                        Console.Write("Добавить нового сотрудника: ");
                        Sotrudniki.Add(Console.ReadLine());

                        foreach (string sotrudnik in Sotrudniki)
                        {

                            Console.WriteLine(sotrudnik);

                        }

                        break;

                    case "Delete":


                        Console.WriteLine("Выберите:\n 1. Если хотите удалить по имени\n 2. Если хотите удалить по номеру");
                        int action1 = Convert.ToInt32(Console.ReadLine());
                        
                        if (action1 == 1)
                        {
                            foreach (string sotrudnik in Sotrudniki)
                            {

                                Console.WriteLine(sotrudnik);

                            }

                            Console.Write("Напишите ФИО сотрудника, которого хотите удалить: ");
                            Sotrudniki.Remove(Console.ReadLine());

                            foreach (string sotrudnik in Sotrudniki)
                            {

                                Console.WriteLine(sotrudnik);

                            }
                        }
                        else
                        {
                            foreach (string sotrudnik in Sotrudniki)
                            {

                                Console.WriteLine(sotrudnik);

                            }

                            Console.WriteLine("Напишите номер сотрудника которого хотите удалить: ");
                            Sotrudniki.RemoveAt(Convert.ToInt32(Console.ReadLine())-1);

                            foreach (string sotrudnik in Sotrudniki)
                            {

                                Console.WriteLine(sotrudnik);

                            }
                        }
                        break;



                    case "Viewing":

                        foreach (string sotrudnik in Sotrudniki)
                        {

                            Console.WriteLine(sotrudnik);

                        }

                        break;
                }


            }



        }
    }
}
