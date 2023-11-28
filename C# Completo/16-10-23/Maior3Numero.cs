using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificando qual é o maior entre os três numeros ");
            Console.WriteLine("Digite o primeiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Terceiro: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior é " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("Maior é " + n2);
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("Maior é " + n3);
            }
            else
            {
                Console.WriteLine("Os Tres Numeros são Iguais!");
            }

        }
    }
}

//segunda versão 


using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificando qual é o maior entre os três numeros ");
            Console.WriteLine("Digite o primeiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Terceiro: ");
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int n1, int n2, int n3)
        {
            int m;

            if (n1 > n2 && n1 > n3)
            {
                m = n1;
            }
            else if (n2 > n3)
            {
                m = n2;
            }
            else
            {
                m = n3;
            }

            return m;
        }
    }
}


