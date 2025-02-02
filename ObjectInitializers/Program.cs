using System;
using ObjectInitializers;


Console.WriteLine("***** Fun with Object Init Syntax *****\n");

/* Point firstPoint = new Point();
firstPoint.X = 10;
firstPoint.Y = 10;
firstPoint.DisplayStats();

Point anotherPoint = new Point(20, 20);
anotherPoint.DisplayStats();
*/
Point finalPoint = new Point {X = 30, Y = 30};
finalPoint.DisplayStats();
Console.ReadLine();

ReadOnlyPointAfterCreation firstReadOnlyPoint = new ReadOnlyPointAfterCreation(20, 20);
firstReadOnlyPoint.DisplayStats();

firstReadOnlyPoint.DisplayStats();

ReadOnlyPointAfterCreation secondReadOnlyPoint = new ReadOnlyPointAfterCreation {X = 30, Y = 30};
secondReadOnlyPoint.DisplayStats();

secondReadOnlyPoint.X = 10;
secondReadOnlyPoint.Y = 10;

secondReadOnlyPoint.DisplayStats();
