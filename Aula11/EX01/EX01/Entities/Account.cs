using EX01.Entities.Exception;

namespace EX01.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                Balance += amount;
            }
            else
            {
                throw new WithdrawException("Value to deposit must be more than zero");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new WithdrawException("The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new WithdrawException("Not enough balance");
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Balance: {Balance}";
        }
    }
}
