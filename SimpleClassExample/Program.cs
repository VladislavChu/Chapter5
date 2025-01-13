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


Motorcycle c = new Motorcycle(5);
c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine($"Rider name is {c.driverName}");

Motorcycle m1 = new Motorcycle();
Console.WriteLine($"Name: {m1.driverName}, Intensity: {m1.driverIntensity}");
Motorcycle m2 = new Motorcycle(name: "Tiny");
Console.WriteLine($"Name: {m2.driverName}, Intensity: {m2.driverIntensity}");
Motorcycle m3 = new Motorcycle(7);
Console.WriteLine($"Name: {m3.driverName}, Intensity: {m3.driverIntensity}");
