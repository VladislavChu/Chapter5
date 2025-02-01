﻿using System;
using System.Xml.Linq;

namespace EmployeeApp
{
    class Employee
    {
        //data fields
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;
        private string _empSSN;
        private EmployeePayTypeEnum _payType;

        //properties
        public string Name
        {
            get
            { 
                if (_empName == null)
                {
                    return "There is no values! null!";
                }
                else
                {
                    return _empName;
                }
            }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        public int Id
        {
            //get { return _empId; }
            //record only!
            set { _empId = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }
        public int Age
        {
            get => _empAge;
            set => _empAge = value;
        }
        public string SocialSecurityNumber
        {
            get => _empSSN;
            private set => _empSSN = value;
        }
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }



        /*
        //getter
        public string GetName () => _empName;

        //setter
        public void SetName (string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = name;
            }
        }
        */

        //ctors
        public Employee() { }
        public Employee(string name, int id, float pay) :this (name, id, pay, 0, "", EmployeePayTypeEnum.Salaried) {}
        public Employee(string name, int id, float pay, int age, string ssn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Pay = pay;
            Age = age;
            SocialSecurityNumber = ssn;
            PayType = payType;
        }

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
