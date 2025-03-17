using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Cone
    {
        private double r;
        private double h;
        private double pi = Math.PI;

        public double Radius
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }

        public double Height
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }

        public double AreaBase()
        {
            return r * r * pi;
        }
        public double AreaSideBase()
        {
            return pi * r * Math.Sqrt(r * r * h * h);
        }
        public double AreaFullBase()
        {
            return AreaBase() + AreaSideBase();
        }

    }


}
