using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal abstract class Shape
    {

        public abstract double GetArea();
        public abstract double GetPerimetr();

        public override string ToString()
        {
            return $"Площадь: {Math.Round(GetArea())} кв.см\nПериметр: {Math.Round(GetArea(), 2)} см\n";
        }

        public static double operator +(Shape a, Shape b)
        {
            return a.GetArea() + b.GetArea();
        }

        public static bool operator >(Shape a, Shape b)
        {
            return a.GetArea() > b.GetArea();
        }

        public static bool operator <(Shape a, Shape b)
        {
            return a.GetArea() > b.GetArea();
        }
    }
}
