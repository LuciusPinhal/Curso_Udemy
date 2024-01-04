namespace Basic.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRage { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRage) : base(number, holder, balance)
        {
            InterestRage = interestRage;
        }
        public void UpdateBalanceRage()
        {
            Balance += Balance * InterestRage;
        }
    }
}
