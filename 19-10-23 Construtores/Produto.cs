using System;
using System.Globalization;

namespace curso
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Qtd = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Qtd * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Qtd += quantidade;
        }

        public void RemoverProdutos(int remove)
        {
            Qtd -= remove;
        }

        //Console.WriteLine(p); para quando digitar p ele vir dessa maneira formatado
        public override string ToString()
        {
            return "Nome: " + Nome
                + ", Preço: $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Qtd
                + " UN, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
