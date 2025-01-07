using System;
using SimpleClassExample;


Console.WriteLine("=> Fun with Class Types.\n");


Car defaultCar = new Car("Mitsubisi", 120, out bool inDanger);
defaultCar.PrintState();
Console.ReadLine();

Car myCar = new Car();
myCar.carName = "Nissan Skyline";
myCar.currentSpeed = 80;

for (int i = 0; i < 10; i++)
{
    myCar.PrintState();
    myCar.SpeedUp(5);
}
Console.ReadLine();


Motorcycle mc = new Motorcycle(5);
mc.PopAWheely();