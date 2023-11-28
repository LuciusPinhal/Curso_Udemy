using System;
using System.Globalization;

namespace curso
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _qtd;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _qtd = quantidade;
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

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _qtd; }
        }


        public double ValorTotalEmEstoque()
        {
            return _qtd * _preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _qtd += quantidade;
        }

        public void RemoverProdutos(int remove)
        {
            _qtd -= remove;
        }

        //Console.WriteLine(p); para quando digitar p ele vir dessa maneira formatado
        public override string ToString()
        {
            return "Nome: " + _nome
                + ", Preço: $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + _qtd
                + " UN, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
