using System;
using FunWithRecords;


Console.WriteLine("Fun with records!");

Car myCar = new Car
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My car: ");
DisplayCarStats(myCar);

Car anotherCar = new Car("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car: ");
DisplayCarStats(anotherCar);
Console.WriteLine();

Console.ReadLine();

Console.WriteLine("/********************RECORDS********************/");

//CarRecord myCarRecord = new CarRecord
//{
//    Make = "Honda",
//    Model = "Pilot",
//    Color = "Blue"
//};
CarRecord myCarRecord = new CarRecord("Honda", "Pilot", "Blue");
Console.WriteLine("My car: ");
Console.WriteLine(myCarRecord.ToString());

CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car: ");
Console.WriteLine(anotherMyCarRecord.ToString());
Console.WriteLine();



static void DisplayCarStats(Car c)
{
    Console.WriteLine($"Care Make: {c.Make}");
    Console.WriteLine($"Care Model: {c.Model}");
    Console.WriteLine($"Care Color: {c.Color}");
}


