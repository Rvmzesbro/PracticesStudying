using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimetr()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Окружность с радиусом: {Radius}\n{base.ToString()}";
        }
    }
}
