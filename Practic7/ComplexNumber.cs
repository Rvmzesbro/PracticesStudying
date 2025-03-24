using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    internal class ComplexNumber : AbstractNumber
    {
        public double Re {  get; set; }
        public double Im { get; set; }

        public ComplexNumber(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public override void Print()
        {
            Console.WriteLine($"Комплексное число: {Re} {(Im >= 0 ? "+" : "-")} {Math.Abs(Im)}i");
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Re + b.Re, a.Im + b.Im);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Re - b.Re, a.Im - b.Im);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(
                a.Re * b.Re - a.Im * b.Im,
                a.Re * b.Im + a.Im * b.Re
                );
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double divisor = b.Re * b.Re + b.Im * b.Im;
            if (divisor == 0)
                throw new DivideByZeroException("Деление на ноль :)");

            return new ComplexNumber(
                (a.Re * b.Re + a.Im * b.Im) / divisor,
                (a.Im * b.Re - a.Re * b.Im) / divisor
                );
        }
    }
}
