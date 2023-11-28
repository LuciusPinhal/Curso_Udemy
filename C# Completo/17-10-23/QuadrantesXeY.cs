using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
            //cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            //menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma)

            Console.WriteLine("Verifica X e Y e qual quadrante eles pertence !");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Digite o X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite o Y: ");
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x >= 1 && y >= 1)
                {
                    Console.WriteLine("X e Y São Positivos e pertencem ao ---- Primeiro quadrante ----");

                }
                else if (x <= -1 && y >= 1)
                {
                    Console.WriteLine("Como X é Negativo e Y Postivo então pertencem ao ---- Segundo quadrante ----");
                }
                else if (x >= 1 && y <= -1)
                {
                    Console.WriteLine("X e Y São Negativos e pertencem ao ---- Quarto quadrante ----");
                }
                else
                {
                    Console.WriteLine("Como Y é Negativo e X Postivo então pertencem ao ---- Terceiro quadrante ----");
                }
                Console.WriteLine("---------------------------------------------------------------------");
                Console.Write("Digite novamente o Valor de X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite novamente o Valor de y: ");
                y = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Encerrado por algoritomo NULO !");
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
