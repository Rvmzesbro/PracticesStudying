using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Cordinate
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Cordinate(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Cordinate operator*(int a,  Cordinate cordinate)
        {
            return new Cordinate(cordinate.X * a, cordinate.Y * a);
        }

        public static Cordinate operator *(Cordinate cordinate1, Cordinate cordinate2)
        {
            return new Cordinate(cordinate1.X * cordinate2.Y, cordinate1.Y * cordinate2.X);
        }

        public void GetInformation()
        {
            Console.WriteLine($"{X}, {Y}");
        }
    }
}
