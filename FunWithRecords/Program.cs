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

Console.WriteLine($"Car are the same? {myCar.Equals(anotherCar)}");
Console.WriteLine($"Car are the same reference? {ReferenceEquals (myCar, anotherCar)}");


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

Console.WriteLine($"CarRecords are the same? {myCarRecord.Equals(anotherMyCarRecord)}");
Console.WriteLine($"CarRecords are the same? {ReferenceEquals (myCarRecord, anotherMyCarRecord)}");
Console.WriteLine($"CarRecords are the same? {myCarRecord == anotherMyCarRecord}");
Console.WriteLine($"CarRecords are not the same? {myCarRecord != anotherMyCarRecord}");
Console.ReadLine();

CarRecord carRecordCopy = anotherMyCarRecord;
Console.WriteLine($"CarRecordCopy are the same? {carRecordCopy.Equals(anotherMyCarRecord)}");
Console.WriteLine($"CarRecordCopy are the same? {ReferenceEquals(carRecordCopy, anotherMyCarRecord)}");
Console.ReadLine();

CarRecord outOtherCar = myCarRecord with { Model = "Odyssey" };
Console.WriteLine("My copied car: ");
Console.WriteLine(outOtherCar.ToString());
Console.WriteLine("Car Record copy using with expression results");
Console.WriteLine($"CarRecordCopy are the same? {outOtherCar.Equals(myCarRecord)}");
Console.WriteLine($"CarRecordCopy are the same? {ReferenceEquals(outOtherCar, myCarRecord)}");
Console.ReadLine();


static void DisplayCarStats(Car c)
{
    Console.WriteLine($"Care Make: {c.Make}");
    Console.WriteLine($"Care Model: {c.Model}");
    Console.WriteLine($"Care Color: {c.Color}");
}


