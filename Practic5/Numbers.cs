using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic5
{
    public static class Numbers
    {
        //static int StartNumber = 1;
        //public static int Number { get; set; }
        //public static double A { get; set; }
        //public static double B { get; set; }
 
        //private static int GetNumber() => StartNumber++;
        // Сумма
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        //  Разность
        public static double Difference(double a, double b)
        {
            return a - b;
        }
        // Умножение
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        // Деление
        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль недопустимо");
            }
            else
            {
                return a / b;
            }
        }
        // Остаток от деления двух целых чисел
        public static int DivisionIntNumbers(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Деление на ноль недопустимо");
            }
            else
            {
                return a % b;
            }
        }
        // Возведение в степень
        public static double ElevationToTheDegree(double a, double b)
        {
            return Math.Pow(a, b);
        }

        //public static void GetInformation()
        //{
        //    Console.WriteLine($"Арифметическая операция № {Number}\n Числа: {A} и {B}\n Сложение {A} + {B} = {Sum(A, B)}\n Вычитание {A} - {B} = {Difference(A, B)}\n " +
        //        $"Умножение {A} * {B} = {Multiplication(A, B)}\n Деление {A} : {B} = {Division(A, B)}\n Остаток от деления двух целых чисел {A} : {B} = {DivisionIntNumbers(((int)A), ((int)B))}\n Возведение в степень {A} ^ {B} = {ElevationToTheDegree(A,B)}\n");
        //}
    }
}
