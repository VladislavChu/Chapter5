using System;
using EmployeeApp;



Console.WriteLine("***** Fun with Encapsulation *****\n");

Employee emp = new Employee("Marvin", 456, 30_000, 31, "1921688821", EmployeePayTypeEnum.Hourly);
//emp.Name = "stacy";
//emp.SetName("Vladik");
Console.WriteLine(emp.Pay);
emp.GiveBonus(10);
Console.WriteLine(emp.Pay);

Console.ReadLine();


Employee emp2 = new Employee();
//emp2.SetName("Xena the warrior princess");

Console.WriteLine(emp2.Name);

Console.ReadLine();


Employee joy = new Employee();
joy.Age++;