using System;
using System.Globalization;

namespace Basic.Entities
{
    class UsedProduct : Produtc
    {
        public DateTime ManufactureDate { get; set; }


        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string priceTag()
        {
            string formatting = Name + " (Used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
            return formatting;
        }
    }
}
