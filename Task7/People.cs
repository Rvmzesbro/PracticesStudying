using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class People
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public People(string fullname, string gender)
        {
            this.FullName = fullname;
            this.Gender = gender;
        }
        public virtual void GetInformation()
        {
            Console.WriteLine($"Привет, меня зовут: {FullName}! Мой пол: {Gender}");
        }
    }
}
