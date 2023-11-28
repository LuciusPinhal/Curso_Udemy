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

            Console.Write("Qual é a cotação do dolar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar: ");
            double qts = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Conversor = Calculadora.ConversorDeMoeda(dolar, qts);

            Console.WriteLine("Valor a ser pago em reais = " + Conversor.ToString("F2", CultureInfo.InvariantCulture));

        }


    }
}
