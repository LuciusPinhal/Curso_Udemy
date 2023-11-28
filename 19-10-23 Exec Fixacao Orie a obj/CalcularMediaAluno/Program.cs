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
            //Media minima é 60 
            Aluno a = new Aluno();

            Console.Write("Entre com o Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Primeira Nota: ");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segunda Nota: ");
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Terceira Nota: ");
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Aluno: " + a.Nome);

            Console.WriteLine("Nota final: " + a.CalcularNota());

            if (a.VerificarAprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }

            Console.WriteLine("Bons estudos e até a proximaa");

        }
    }
}
