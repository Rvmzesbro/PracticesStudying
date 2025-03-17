using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Student
    {
        public string FIO { get; set; }
        static int number = 0;
        public Student(string FIO)
        {
            number++;
            this.FIO = FIO;
        }

        public Student()
        {
        }

        public static int GetNumber => number++;

        public static void GetTechnical()
        {
            Console.WriteLine("MCK-KTITS");
        }
        public void GetInformation()
        {
            Console.WriteLine($"Hello {FIO}, {GetNumber}");
        }
    }
}
