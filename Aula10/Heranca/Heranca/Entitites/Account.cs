namespace Heranca.Entitites
{
    //class Account
    abstract class Account
    {
        static protected double withdrawRate = 5.00;

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= (Balance + withdrawRate))
            {
                Balance -= amount + withdrawRate;
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
