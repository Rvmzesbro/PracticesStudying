using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static int health = 100;
        static int arrows = 5;
        static int gold = 0;
        static int potions = 3;
        static List<string> inventory = new List<string>();
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в подземелье!");
            string[] dungeon = GenerateDungeon();
            bool run = true;
            int lvl = 0;
            Console.WriteLine("Выберите комнату в которую хотите зайти(1-10)");
            while (run)
            {
                Console.WriteLine("Выберите комнату в которую хотите зайти(1-10)");
                lvl = Convert.ToInt32(Console.ReadLine());
                ProcessRoom(dungeon[lvl - 1]);
            }

            Console.WriteLine("Поздравляем! Вы прошли подземелье!");
        }

        static string[] GenerateDungeon()
        {
            string[] rooms = new string[10];
            string[] possibleRooms = { "Монстр", "Ловушка", "Сундук", "Торговец", "Пустая комната" };
            for (int i = 0; i < 9; i++)
            {
                rooms[i] = possibleRooms[rand.Next(possibleRooms.Length)];
            }
            rooms[9] = "Босс"; // Последняя комната всегда босс
            return rooms;
        }

        static void ProcessRoom(string room)
        {
            switch (room)
            {
                case "Монстр": FightMonster(); break;
                case "Ловушка": TriggerTrap(); break;
                case "Сундук": OpenChest(); break;
                case "Торговец": VisitMerchant(); break;
                case "Пустая комната": Console.WriteLine("Ничего не происходит."); break;
                case "Босс": FightMonster(true); break;
            }
        }

        static void FightMonster(bool isBoss = false)
        {
            int monsterHp = isBoss ? 100 : rand.Next(20, 50);
            Console.WriteLine($"Вы сражаетесь с {(isBoss ? "БОССОМ" : "монстром")}! Здоровье врага: {monsterHp}");

            while (monsterHp > 0 && health > 0)
            {
                Console.WriteLine("Выберите оружие: Меч(1), Лук(2), Лечебка(3)");
                string choice = Console.ReadLine();
                int damage = 0;
                if (choice == "1")
                {
                    damage = rand.Next(10, 20);
                    Console.WriteLine($"Вы ударили мечом! Урон: {damage}");
                }
                else if (choice == "2" && arrows > 0)
                {
                    damage = rand.Next(5, 15);
                    arrows--;
                    Console.WriteLine($"Вы выстрелили из лука! Урон: {damage}, Осталось стрел: {arrows}");
                }
                else if (choice == "3")
                {
                    Usepoint();
                }
                else
                {
                    Console.WriteLine("Неверный выбор или недостаточно стрел!");
                    continue;
                }

                monsterHp -= damage;
                if (monsterHp <= 0) break;
                int monsterDamage = rand.Next(5, 15);
                health -= monsterDamage;
                Console.WriteLine($"Монстр атаковал! Вы потеряли {monsterDamage} HP. Осталось здоровья: {health}");
            }

            if (health > 0)
                Console.WriteLine("Вы победили!");
        }

        static void TriggerTrap()
        {
            int damage = rand.Next(10, 20);
            health -= damage;
            Console.WriteLine($"Вы попали в ловушку! Потеряно {damage} HP. Осталось здоровья: {health}");
        }

        static void OpenChest()
        {
            Console.WriteLine("Вы нашли сундук! Решите загадку, чтобы открыть его.");
            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);
            Console.WriteLine($"Сколько будет {a} + {b}?");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == a + b)
            {
                string[] rewards = { "стрелы", "золото", "зелье" };
                string reward = rewards[rand.Next(rewards.Length)];
                Console.WriteLine($"Вы правильно ответили! В сундуке {reward}.");
                if (reward == "стрелы") arrows += 3;
                if (reward == "золото") gold += 20;
                if (reward == "зелье") potions++;
            }
            else
            {
                Console.WriteLine("Неверный ответ! Сундук закрыт.");
            }
        }

        static void VisitMerchant()
        {
            Console.WriteLine("Вы встретили торговца! Хотите купить зелье за 30 золота? (да/нет)");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "да" && gold >= 30)
            {
                gold -= 30;
                potions++;
                Console.WriteLine("Вы купили зелье!");
            }
            else
            {
                Console.WriteLine("Недостаточно золота или отказ от покупки.");
            }
        }

        static void Usepoint()
        {
            health = health + rand.Next(10, 30);
            potions = potions - 1;
        }
    
    }
}
