using Basic.Entities;
using Basic.Entities.Execptions;
using System.Globalization;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            char loopProgram = 'y';

            while (loopProgram != 'n')
            {
                Console.WriteLine("Enter Account data");

                Console.Write("Number: ");
                int number;
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input for Number. Please enter a valid integer.");
                    continue;  // Volta para o início do loop
                }

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance;
                if (!double.TryParse(Console.ReadLine(), out balance))
                {
                    Console.WriteLine("Invalid input for Initial balance. Please enter a valid number.");
                    continue;  // Volta para o início do loop
                }

                Console.Write("Withdraw limit: ");
                double withdraw;
                if (!double.TryParse(Console.ReadLine(), out withdraw))
                {
                    Console.WriteLine("Invalid input for Withdraw limit. Please enter a valid number.");
                    continue;  // Volta para o início do loop
                }

                Account acc = new Account(number, holder, balance, withdraw);
                Console.WriteLine();

                //Console.Write("Enter the deposit amount: ");
                //double amount = double.Parse(Console.ReadLine());
                //acc.Deposit(amount);

                //Console.WriteLine("Updated balance: R$ " + acc.Balance.ToString("F2",CultureInfo.InvariantCulture));

                try
                {
                    Console.Write("Enter amount for withdraw: ");
                    double amount = double.Parse(Console.ReadLine());
                    acc.Withdraw(amount);
                    Console.WriteLine("Updated balance: R$ " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
                }
                catch (DomainExeception e)
                {
                    Console.WriteLine("Withdraw error: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected error: " + e.Message);
                }

                Console.WriteLine();
                Console.Write("Do you want to exit? (y/n): ");
                loopProgram = char.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }

    }
}