using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic6
{
    internal class Manager : Employee
    {
        double Result;
        public int TeamSize { get; set; }

        public Manager(string name, int age, double salary, int teamsize):base(name, age, salary)
        {
            TeamSize = teamsize;
        }

        public double BonusManager()
        {
            return Result = Salary + (Salary * 10) / 100 + TeamSize*500;
        }
 
        public override void ShowInfo()
        {
            Console.WriteLine(" Я менеджер этой компании");
            base.ShowInfo();
            Console.WriteLine($" Мой размер команды: {TeamSize}\n Моя зарплата: {Salary} руб\n А зарплата с бонусом: {Result} руб\n");
        }
    }
}
