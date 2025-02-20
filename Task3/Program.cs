using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Person("Wow");
            Console.WriteLine(Sum());
            int[] Array1 = ArrayInput(7);
            ArrayPrint(Array1);
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum1(ref a));
            Console.WriteLine(factorial(5));
            Sum3(2, 4, out int sum);
            Console.WriteLine(sum);
        }

        static void Hello()
        {
            Console.WriteLine("Htllo world");
        }

        static void Person(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static double Sum()
        {
            Console.WriteLine("Inpyt a");
            int a = int.Parse( Console.ReadLine() );
            Console.WriteLine("Inpyt b");
            int b = int.Parse(Console.ReadLine());
            return a + b;
        }

        static int[] ArrayInput(int length)
        {
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(0,9);
            }
            return array;
        }

        static void ArrayPrint(int[] array)
        {
            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int Sum1(ref int a)
        {

            return a + 10;
        }

        // Рекурсивный метод
        static int factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * (factorial(n-1));
        }
        // ref сохраняет значение переменной

        static void Sum3(int a, int b, out int sum)
        {
            sum = a + b;
        }
    }
}
