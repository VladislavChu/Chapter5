using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        private static double _currInterestRate = 0.04;

        public double currBalance;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            //currInterestRate = 0.4;
        }

        public static double InterestRate
        {
            get { return _currInterestRate; }
            set { _currInterestRate = value; }
        }

        //public static void SetInterestRate(double newRate) => currInterestRate = newRate;
        //public static double GetInterestRate() => currInterestRate;
    }
}
