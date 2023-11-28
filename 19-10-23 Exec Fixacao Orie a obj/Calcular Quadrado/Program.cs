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

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a Largura e altura do retangulo: ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Área: " + r.CalcularArea());
            Console.WriteLine("Perímetro: " + r.CalcularPerimetro());
            Console.WriteLine("Diagonal: " + r.CalcularDiagonal());

        }
    }
}
