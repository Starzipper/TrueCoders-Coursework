﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance;

        public void Deposit(double deposit)
        {
            balance += deposit;
        }

        public void Withdraw(double withdrawal)
        {
            balance -= withdrawal;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
