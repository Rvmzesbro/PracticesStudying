using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FIO = "Иванов Иван Иванович";
            student.GetInformation();
            Student.GetTechnical();

            
            Calculator.Sum(12, 2);
            Calculator.Name = "Куку";
            
        }
    }
}
