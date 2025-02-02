using System;
using AutoProp;


Console.WriteLine("***** Fun with Automatic Properties *****\n");

Car porshe = new Car();
porshe.CarName = "911";
porshe.Speed = 209;
porshe.Color = "Blue";

Console.WriteLine($"Your car is named {porshe.CarName}?");
porshe.DisplayStats();

Console.ReadLine();

Garage oldCars = new Garage();

oldCars.MyAuto = porshe;

Console.WriteLine($"Number of Cars: {oldCars.NumberOfCars}");

Console.WriteLine(oldCars.MyAuto.CarName);
Console.WriteLine(oldCars.MyAuto.Speed);
Console.WriteLine(oldCars.MyAuto.Color);
Console.WriteLine(oldCars.MyAuto);




