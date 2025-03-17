using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic6
{
    internal class Intern : Employee
    {
        double Result;
        public string University { get; set; }

        public Intern(string name, int age, double salary, string university):base(name, age, salary)
        {
            University = university;
        }

        public double BonusUniversity()
        {
            return Result = Salary + (Salary * 3) / 100;
        }

        public override void ShowInfo()
        {
            Console.WriteLine(" Я стажер это компании");
            base.ShowInfo();
            Console.WriteLine($" Мое место работы: {University}\n Моя зарплата: {Salary} руб\n А с бонусом: {Result} руб\n");
        }
    }
}
