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
            //Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            //exemplo.

            Console.Write("Informe um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Para cada linha ele vai pegar o primeiro valor e multiplicar pelo quadrado e pelo cubo");
            Console.WriteLine("---------------------------------------------------------------------");
            for (int i = 1; i <= x; i++)
            {
                int valor02 = i * i;
                int valor03 = i * i * i;
                Console.WriteLine("Valor da " + i + " Linha: " + i + " " + valor02 + " " + valor03);
                Console.WriteLine("---------------------------------------------------------------------");
            }

        }
    }
}
