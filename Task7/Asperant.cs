using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Asperant : Student
    {
        public bool IsMagister { get; set; }

        public Asperant(string fullname, string gender, double point, bool ismagister) : base(fullname, gender, point)
        {
            this.IsMagister = ismagister;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Магистр ли я: {(IsMagister ? "Да" : "Нет")}");
        }
    }
}
