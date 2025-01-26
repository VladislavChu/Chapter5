using System;
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
            get { return _empId; }
            set { _empId = value; }
        }
        public float CurrentPay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }
        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
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
        public Employee(string name, int id, float pay) :this (name, id, pay, 0) {}
        public Employee(string name, int id, float pay, int age)
        {
            _empName = name;
            _empId = id;
            _currPay = pay;
            _empAge = age;
        }

        //methods
        public void GiveBonus(float amount) => _currPay += amount;
        public void DisplayStatus()
        {
            Console.WriteLine($"Name: {_empName}");
            Console.WriteLine($"ID: {_empId}");
            Console.WriteLine($"Pay: {_currPay}");
            Console.WriteLine($"Age: {_empAge}");
        }
    }
}
