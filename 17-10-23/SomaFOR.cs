using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos Numeros inteiros voce vai digitar: ");
            int x = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= x; i++)
            {
                Console.Write("Valor #{0} : ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Total da Soma : " + soma);
        }
    }
}
