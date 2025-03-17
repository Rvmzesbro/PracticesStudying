using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Student : People
    {
        public double Point { get; set; }

        public Student(string fullname, string gender, double point) : base(fullname, gender)
        {
            this.Point = point;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Мой средний балл: {Point}");
        }
    }
}
