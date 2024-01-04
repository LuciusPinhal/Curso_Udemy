using Basic.Entities;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500.0);

            //upcasting conversão de subClasse para SUPERClasse

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "BoB", 0.0, 500.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            // DownCasting conversão da UPERClasse para subClasse
            //DownCasting é operação insegura 
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // SavingsAccount - da erro 
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            //como testar a variavel é instancia
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                //outra forma de fazer um DownCasting
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalanceRage();
                Console.WriteLine("Update");
            }
        }
    }
}