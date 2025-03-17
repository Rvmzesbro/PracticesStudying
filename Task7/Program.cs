using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People people = new People("Иванов Иван Иванович", "Мужской");
            people.GetInformation();

            Student student = new Student("Петров Петр Петрович", "Мужской", 4);
            student.GetInformation();

            Asperant asperant = new Asperant("Сергеев Сергей Сергеевич", "Мужской", 5, true);
            asperant.GetInformation();
        }
    }
}
