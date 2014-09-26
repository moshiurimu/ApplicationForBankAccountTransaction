using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Account
    {
        public string acNumber;
        public string name;
        public double balance;

        public void Deposite(double amount)
        {
            balance += amount;
        }

        public void Withdraw (double amount)
        {
            balance -= amount;
        }
    }
}
