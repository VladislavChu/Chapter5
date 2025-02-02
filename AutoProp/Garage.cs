using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProp;

namespace AutoProp
{
    internal class Garage
    {
        public int NumberOfCars { get; set; } = 1;

        public Car MyAuto { get; set; } = new Car();

         public Garage()
        {
            /* MyAuto = new Car();
             NumberOfCars = 1;
            */
        }

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }

    }
}
