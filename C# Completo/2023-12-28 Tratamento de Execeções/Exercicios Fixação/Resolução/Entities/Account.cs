using Basic.Entities.Execptions;

namespace Basic.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            switch (amount)
            {
                case double value when (value > WithdrawLimit):
                    throw new DomainExeception("The amount exceeds withdraw limit");

                case double value when (value > Balance):
                    throw new DomainExeception("Not enough balance");

                case double value when (Balance >= value):
                    Balance -= amount;
                    break;
                   
            }



        }

    }
}
