namespace Basic.Entities
{
    //não deixa essa classe ser herdada Sealed
    sealed class SavingsAccount : Account
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

        //Não pode ser sobrescrita novamente em outra SubClasse
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;

        }
    }
}
