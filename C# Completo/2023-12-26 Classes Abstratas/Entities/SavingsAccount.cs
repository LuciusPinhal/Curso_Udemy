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
        //dessa forma ele sobrescreve o Wthdraw

        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}

        //dessa forma ele não sobrescreve e ainda tira os 2 reais
        public override void Withdraw(double amount)
        {
            //efetua o saque de acordo com a regra da superClasse
            base.Withdraw(amount);
            Balance -= 2.0;

        }
    }
}
