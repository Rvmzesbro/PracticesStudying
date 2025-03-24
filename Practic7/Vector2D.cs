using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal class Vector2D : AbstractNumber
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D(double x, double y)
        {
            X = x; Y = y;
        }

        public override void Print()
        {
            Console.WriteLine($"Вектор X: {X}\nВектор Y: {Y}\n");
        }
    }
}
