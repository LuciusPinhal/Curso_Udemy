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

            Funcionario Pessoa1, Pessoa2;

            Pessoa1 = new Funcionario();
            Pessoa2 = new Funcionario();


            Console.WriteLine("Informe os dados do primeiro funcionario:");
            Console.Write("Nome:");
            Pessoa1.Nome = Console.ReadLine();
            Console.Write("Salario:");
            Pessoa1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Informe os dados do segundo funcionario:");
            Console.Write("Nome:");
            Pessoa2.Nome = Console.ReadLine();
            Console.Write("Salario:");
            Pessoa2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double media = (Pessoa1.Salario + Pessoa2.Salario) / 2;
            Console.WriteLine("Salário médio entre " + Pessoa1.Nome + " e " + Pessoa2.Nome + " é de " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
