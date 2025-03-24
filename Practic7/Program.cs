using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            
            Shape circle = new Circle(5);
            
            

            Console.WriteLine(circle);
            Console.WriteLine(rectangle);

            Console.WriteLine($"Сумма площадей: {Math.Round(circle + rectangle, 2)} кв.см");
            Console.WriteLine($"Окружность > Прямоугольника: {circle > rectangle}");
            Console.WriteLine($"Окружность < Прямоугольника: {circle < rectangle}\n");

            Vector2D vector2D = new Vector2D(10, 10);
            vector2D.Print();

            ComplexNumber num1 = new ComplexNumber(10, 10);
            ComplexNumber num2 = new ComplexNumber(20, 20);
            num1.Print();
            num2.Print();

            ComplexNumber sum = num1 + num2;
            ComplexNumber dif = num1 - num2;
            ComplexNumber mult = num1 * num2;
            ComplexNumber div = num1 / num2;

            Console.WriteLine($"\nРезультаты операций");
            sum.Print();
            dif.Print();
            mult.Print();
            div.Print();
        }
    }
}
