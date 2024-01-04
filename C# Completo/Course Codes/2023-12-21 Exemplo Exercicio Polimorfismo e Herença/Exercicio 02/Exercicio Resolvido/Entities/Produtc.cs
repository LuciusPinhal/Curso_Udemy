using System.Globalization;

namespace Basic.Entities
{
    class Produtc
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Produtc() { }

        public Produtc(string name, double price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Tag para cada tipo de Produto (Comum, usado e Importado)
        /// </summary>
        /// <returns>Tostring dando override para cada um (c/u/i)</returns>
        public virtual string priceTag()
        {
            string formatting = Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
            return formatting;
        }
    }
}
