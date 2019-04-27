using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entitites
{
    //sealed class SavingsAccount : Account
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance()
        {
            Balance *= (1 + InterestRate / 100);
        }

        //public override void Withdraw(double amount)
        //{
        //    if (amount <= Balance)
        //    {
        //        Balance -= amount;
        //    }
        //}

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
