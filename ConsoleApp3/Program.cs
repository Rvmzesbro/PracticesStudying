using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int action = 0;
            
            while (action < 3 && action >= 0)
            {
                Console.WriteLine("1. Конус");
                Console.WriteLine("2. Машина");
                Console.WriteLine("Введите команду: ");
                action = int.Parse(Console.ReadLine());
                
                switch (action)
                {
                    case 1:
                        Console.WriteLine("Введите радиус конуса: ");
                        Console.WriteLine("Введите высоту конуса: ");
                        var Cone = new Cone()
                        {
                            Radius = Convert.ToDouble(Console.ReadLine()),
                            Height = Convert.ToDouble(Console.ReadLine()),
                        };
                        Console.WriteLine($"Площадь основания равна: {Cone.AreaBase()}");
                        Console.WriteLine($"Площадь боковой стороны равна: {Cone.AreaSideBase()}");
                        Console.WriteLine($"Площадь полной поверхности равна: {Cone.AreaFullBase()}");
                        break;
                    case 2:
                        Console.WriteLine("Введите марку машины: ");
                        Console.WriteLine("Введите цвет машины: ");
                        Console.WriteLine("Введите цену машины: ");
                        Console.WriteLine("Введите дату выхода машины в формате (ДД.ММ.ГГГГ ЧЧ:ММ:СС): ");
                        var Car = new Car()
                        {
                            Stamp = Console.ReadLine(),
                            Color = Console.ReadLine(),
                            Price = Convert.ToDouble(Console.ReadLine()),
                            DateRelease = Convert.ToDateTime(Console.ReadLine()),
                        };
                        Console.WriteLine($"Возраст машины {Car.GetAge()}");
                        Console.WriteLine($"Цена машины {Car.GetPrice()}");
                        break;
                }
            }
        }
    }
    
}
