using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public static double currInterestRate;

        public double currBalance;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.4;
        }


        public static void SetInterestRate(double newRate) => currInterestRate = newRate;
        public static double GetInterestRate() => currInterestRate;
    }
}
