using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Plane : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Я лечу");
        }
    }
}
