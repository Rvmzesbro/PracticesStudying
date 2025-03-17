using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    static class Calculator
    {
        public static string Name { get; set; }
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }

    }
}
