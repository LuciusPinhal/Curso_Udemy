using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verifica se a senha é Valida '2002' ");
            Console.Write("Digite a senha: ");
            double senha = double.Parse(Console.ReadLine());

            while (senha != 2002)
            {

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Senha Incorreta !");
                Console.Write("Digite novamente a senha: ");
                senha = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}
