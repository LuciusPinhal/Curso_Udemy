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

            Pessoa Pessoa1, Pessoa2;

            Pessoa1 = new Pessoa();
            Pessoa2 = new Pessoa();


            Console.WriteLine("Informe os dados do primeiro funcionario:");
            Console.Write("Nome:");
            Pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade:");
            Pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Informe os dados do segundo funcionario:");
            Console.Write("Nome:");
            Pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade:");
            Pessoa2.Idade = int.Parse(Console.ReadLine());

            if (Pessoa1.Idade > Pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + Pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + Pessoa2.Nome);
            }


        }
    }
}
