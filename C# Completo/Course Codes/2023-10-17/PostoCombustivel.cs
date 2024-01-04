using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            //que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            //exemplo.

            Console.WriteLine("Bem Vindo ao Posto Virtual !");
            Console.WriteLine("Selecione o numero para o Tipo de Combustivél que deseja!");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Temos as seguintes opcões:");
            Console.WriteLine(" 1 - Álcool");
            Console.WriteLine(" 2 - Gasolina");
            Console.WriteLine(" 3 - Diesel");
            Console.WriteLine(" 4 - Fim");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Digite o numero : ");
            int x = int.Parse(Console.ReadLine());


            while (x != 4)
            {
                if (x == 1)
                {
                    Console.WriteLine("Voce selecionou: Álcool");
                }
                else if (x == 2)
                {
                    Console.WriteLine("Voce selecionou: Gasolina");
                }
                else if (x == 3)
                {
                    Console.WriteLine("Voce selecionou: Diesel");
                }
                else
                {
                    Console.WriteLine("Atenção o numero que digitou '" + x + "' não é valido !");
                    Console.WriteLine("Temos as seguintes opcões:");
                    Console.WriteLine(" 1 - Álcool");
                    Console.WriteLine(" 2 - Gasolina");
                    Console.WriteLine(" 3 - Diesel");
                    Console.WriteLine(" 4 - Fim");
                    Console.WriteLine("---------------------------------------------------------------------");
                }

                Console.Write("Digite outro numero para selecionar outro serviço: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------");

            }

            Console.WriteLine("Obrigado pela preferencia, volte sempre!");
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
