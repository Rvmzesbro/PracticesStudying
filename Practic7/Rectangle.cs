using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return (Length * 2) + (Width * 2);
        }

        public override double GetPerimetr()
        {
            return 2 * (Length + Width);
        }

        public override string ToString()
        {
            return $"Прямоугольник с шириной: {Width}, с длиной: {Length}\n{base.ToString()}";
        }
    }
}
