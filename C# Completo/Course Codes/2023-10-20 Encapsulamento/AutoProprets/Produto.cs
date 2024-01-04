using System;
using System.Globalization;

namespace curso
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Qtd = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;

                }
            }
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
            return "Nome: " + _nome
                + ", Preço: $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Qtd
                + " UN, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
