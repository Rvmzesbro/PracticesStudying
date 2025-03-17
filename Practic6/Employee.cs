using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic6
{
    internal class Employee
    {
        double Result;
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public virtual double CalculateBonus()
        {
            return Result = Salary + (Salary*5)/100;
        }

        public void GetInformation()
        {
            Console.WriteLine($" Я сотрудник этой компании\n Меня зовут: {Name}\n Мой возраст: {Age}\n Моя зарплата составляет: {Salary} руб\n А зарплата с бонусом: {Result} руб\n");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($" Меня зовут: {Name}\n Мой возраст: {Age}");
        }
    }
}
