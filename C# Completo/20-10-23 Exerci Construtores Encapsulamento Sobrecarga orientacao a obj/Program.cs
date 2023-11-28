using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo ao banco do Rogerio! ");
            Console.Write("Deseja Criar uma Conta (S/N)?: ");
            string conta = Console.ReadLine();
            while (conta == "s" || conta == "S")
            {
                CriacaoConta();
                Console.WriteLine("------------------------------------------------------------");
                Console.Write("Deseja Outra Conta (S/N)?: ");
                conta = Console.ReadLine();
            }
            Console.WriteLine("Obrigado Volte Sempre !");


        }

        static void VerificaNome(string nome)
        {
            while (nome.Length <= 1)
            {
                Console.WriteLine("O nome tem que ser maior! ");
                Console.Write("Entre o titilar da conta: ");
                nome = Console.ReadLine();
            }

        }

        static void CriacaoConta()
        {
            Console.Write("Entre o número da Conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titilar da conta: ");
            string nome = Console.ReadLine();

            VerificaNome(nome);

            Console.Write("Haverá depósito inicial(S/N): ");
            string DepositoInicial = Console.ReadLine();


            Conta c = new Conta(conta, nome);

            c.VerificaDeposito(DepositoInicial);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para DEPÓSITO: ");
            double valorVariavel = double.Parse(Console.ReadLine());
            c.DepositoConta(valorVariavel);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados da Conta: ");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para SAQUE: ");
            valorVariavel = double.Parse(Console.ReadLine());
            c.SaqueConta(valorVariavel);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados da Conta: ");
            Console.WriteLine(c);
            Console.WriteLine();

        }
    }
}
