using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic5
{
    internal class Buildings
    {
        static int BuildNumber = 1;
        // Уникальный номер
        public int Uniqe_Number {  get; set; }
        // Высота
        public double Height { get; set; }
        // Этажность
        public int Floor { get; set; }
        // Количество квартир
        public int Count_Flat { get; set; }
        // Подъездность
        public int Entranse { get; set; }

        public Buildings(double height, int floor, int count_flat, int entranse)
        {
            this.Uniqe_Number = GetBuilding();
            this.Height = height;
            this.Floor = floor;
            this.Count_Flat = count_flat;
            this.Entranse = entranse;
        }

        private static int GetBuilding() => BuildNumber++;
        internal double GetHeightFloor() => Height / Floor;
        internal double GetCountFlatInEntranse() => Count_Flat / Entranse;
        internal double GetCountFlatOnFloor() => GetCountFlatInEntranse() / Floor;

        public void GetInformation()
        {
            Console.WriteLine($"Здание № {Uniqe_Number} имеет: \n высоту: {Height} м\n Этажность: {Floor} \n Количество квартир: {Count_Flat} \n Подъездность: {Entranse}\n " +
                $"Высота этажа здания: {Math.Round(GetHeightFloor(), 2)} м\n Количество квартир в подъезде: {GetCountFlatInEntranse()}\n Количество квартир на этаже: {Math.Round(GetCountFlatOnFloor(), 2)}\n");
        }
    }
}
