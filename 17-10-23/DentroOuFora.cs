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
            //Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            Console.Write("Informe um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());
            int a_in = 0;
            int a_out = 0;

            Console.WriteLine("Valores entre o intervado de 10 a 20, do NUMERO INFORMADO dentro do intervalo será 'in' fora será 'out' :");
            for (int i = 1; i <= x; i++)
            {
                if (i >= 10 && i <= 20)
                {
                    a_in++;
                }
                else
                {
                    a_out++;
                }
            }
            Console.WriteLine("Total de Valores dentros 'in' : " + a_in);
            Console.WriteLine("Total de Valores fora 'out' : " + a_out);
        }
    }
}
