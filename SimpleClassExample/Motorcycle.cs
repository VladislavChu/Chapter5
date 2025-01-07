using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;
        public void SetDriverName(string name) => this.name = name;
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeeeee Haaaaaaaaaeewww!");
            }
        }

        public Motorcycle() { }

        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }

    }
}
