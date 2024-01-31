using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Entities
{
    class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double Total()
        {
            return preco * quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + nome 
                + "| Valor total: " +
                Total().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
