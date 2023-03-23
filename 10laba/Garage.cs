using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10laba
{
    internal class Garage
    {
        public List<Car> cars { get; set; }

        public Garage()
        {
            cars = new List<Car>();
        }
    }
}
