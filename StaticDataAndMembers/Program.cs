using System;
using StaticDataAndMembers;


Console.WriteLine("***** Fun with static data *****\n");

SavingsAccount s1 = new SavingsAccount(50);

Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");

SavingsAccount.SetInterestRate(0.8);

SavingsAccount s2 = new SavingsAccount(100);

Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");

//avingsAccount s3 = new SavingsAccount(10000.75);
Console.ReadLine();
