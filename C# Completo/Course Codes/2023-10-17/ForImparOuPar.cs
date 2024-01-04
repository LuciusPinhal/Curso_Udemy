using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            //X, se for o caso.

            Console.Write("Informe um numero: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Valores impares :");
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0} ", i);

                }
            }
        }
    }
}
