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



            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Dados do Produto: ");
            Console.WriteLine();
            Console.WriteLine(p);
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine();

            Console.Write("Digite o número de produtos que serão ADICIONADOS no Estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);


            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine();
            Console.WriteLine(p);
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine();

            Console.Write("Digite o número de produtos que serão REMOVIDOS no Estoque: ");
            int remove = int.Parse(Console.ReadLine());
            p.RemoverProdutos(remove);

            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine();
            Console.WriteLine(p);
            Console.WriteLine("---------------------------------------------------------------------");


        }
    }
}
