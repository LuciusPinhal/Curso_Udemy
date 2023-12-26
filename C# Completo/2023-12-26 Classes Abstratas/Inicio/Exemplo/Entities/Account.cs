
namespace Basic.Entities
{
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //virtal colocando que ele pode ser sobreposto
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;

        }
        public void UpdateBalance(double newBalance)
        {
            Balance = newBalance;
        }
    }
}
