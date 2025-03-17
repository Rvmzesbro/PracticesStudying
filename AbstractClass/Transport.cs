using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract class Transport
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public abstract void Move();
    }
}
