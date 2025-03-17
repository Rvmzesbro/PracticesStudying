using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Car
    {
        public string stamp;
        
        public string Stamp
        {
            get { return stamp; }
            set { stamp = value; }
        }

        public string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public DateTime data_release;
        public DateTime DateRelease
        {
            get { return data_release; }
            set { data_release = value; }
        }

        public double GetAge()
        {
            return DateTime.Now.Year - data_release.Year;
        }
        public double GetPrice()
        {
            return price * 0.95;
        }
    }
}
