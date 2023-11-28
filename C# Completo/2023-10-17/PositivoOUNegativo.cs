using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verifica se o Numero é positivo e Mostra sua Raiz quadrada");
            Console.Write("Digite um Número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x > 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine("Raiz Quadrada de " + x + " = " + raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("------------------------------------------------");
                Console.Write("Digite outro Numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Numero Negativo !");
        }
    }
}
