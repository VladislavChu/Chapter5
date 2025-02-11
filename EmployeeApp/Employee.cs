using System;
using System.Xml.Linq;

namespace EmployeeApp
{
    partial class Employee
    {

        //methods
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commmission } => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay += 0
            };
            
        }
            
        public void DisplayStatus()
        {
            Console.WriteLine($"Name: {Name}");
            //Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"SSN: {_empSSN}");
        }
    }
}
