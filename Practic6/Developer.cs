using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic6
{
    internal class Developer : Employee
    {
        double Result;
        public string ProgrammingLanguage { get; set; }
        
        public Developer(string name, int age, double salary, string programmingLanguage):base(name, age, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public double BonusProgrammer()
        {
            return Result = Salary + (Salary * 15) / 100;
        }

        public override void ShowInfo()
        {
            Console.WriteLine(" Я программист этой компании");
            base.ShowInfo();
            Console.WriteLine($" Язык программирование на котором я пишу: {ProgrammingLanguage}\n Моя зарплата: {Salary} руб\n А с бонусом: {Result} руб\n");
        }
    }
}
