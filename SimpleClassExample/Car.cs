using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public string carName;
        public int currentSpeed;

        public Car()
        {
            carName = "Car";
            currentSpeed = 0;
        }

        public Car(string cn) => carName = cn;
        

        public Car(string cn, int cs)
        {
            carName = cn;
            currentSpeed = cs;
        }

        public Car (string cn, int cs, out bool inDanger)
        {
            carName = cn;
            currentSpeed = cs;
            if (cs > 100)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }


        public void PrintState() => Console.WriteLine($"{carName} is going {currentSpeed} MPH");

        public void SpeedUp(int delta) => currentSpeed += delta;

    }
}
