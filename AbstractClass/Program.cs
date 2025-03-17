using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "BMW";
            car.Name = "M3";
            car.Move();

            Plane plane = new Plane();
            plane.Brand = "Airbus";
            plane.Name = "552";
            plane.Move();

            Cordinate A = new Cordinate(10, 100);
            Cordinate B = new Cordinate(2, 43);
            Cordinate C = 5 * A;
            C.GetInformation();
        }
    }
}
