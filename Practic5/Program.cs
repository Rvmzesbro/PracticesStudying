using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание с зданиями
            Buildings buildings = new Buildings(20.5, 9, 200, 5);
            Buildings buildings1 = new Buildings(30, 9, 200, 5);
            buildings.GetInformation();
            buildings1.GetInformation();
            // Задание с операциями над числами
            Numbers.Sum(6, 7);
            Numbers.DivisionIntNumbers(15, 5);
       
        }
    }
}
