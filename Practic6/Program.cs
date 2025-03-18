using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сотрудник
            Employee employee = new Employee("Иванов Иван Иванович", 52, 52000);
            employee.CalculateBonus();
            employee.GetInformation();
            // Менеджер
            Manager manager = new Manager("Петров Петр Петрович", 36, 45000, 5);
            manager.BonusManager();
            manager.ShowInfo();
            // Программист
            Developer developer = new Developer("Сергеев Сергей Сергеевич", 25, 180000, "С#");
            developer.BonusProgrammer();
            developer.ShowInfo();
            // Стажер
            Intern intern = new Intern("Алексеев Алексей Алексеевич", 17, 30000, "Ebay");
            intern.BonusUniversity();
            intern.ShowInfo();

            
        }
    }
}
