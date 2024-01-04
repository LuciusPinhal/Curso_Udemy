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

            Funcionario f = new Funcionario();

            Console.Write("Entre com o Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine();

            Console.WriteLine(f);


            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double Aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(Aumento);

            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine();

            Console.WriteLine(f);


            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");



        }
    }
}
