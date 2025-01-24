using System;

namespace EmployeeApp
{
    class Employee
    {
        //data fields
        private string _empName;
        private int _empId;
        private float _currPay;

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

        //ctors
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            _empName = name;
            _empId = id;
            _currPay = pay;
        }

        //methods
        public void GiveBonus(float amount) => _currPay = amount;
        public void DisplayStatus()
        {
            Console.WriteLine($"Name: {_empName}");
            Console.WriteLine($"ID: {_empId}");
            Console.WriteLine($"Pay: {_currPay}");
        }
    }
}
