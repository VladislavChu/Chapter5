using System;
using EmployeeApp;



Console.WriteLine("***** Fun with Encapsulation *****\n");

Employee emp = new Employee("Marvin", 456, 30_000);
//emp.Name = "stacy";
//emp.SetName("Vladik");
emp.GiveBonus(100_000_000);
emp.DisplayStatus();

Console.ReadLine();


Employee emp2 = new Employee();
//emp2.SetName("Xena the warrior princess");

Console.WriteLine(emp2.Name);

Console.ReadLine();


Employee joy = new Employee();
joy.Age++;