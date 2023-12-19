namespace Basic.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        //Não precisa declarar basta colocar o base que ele pega o construtor da SuperClasse, Account
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {           
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
