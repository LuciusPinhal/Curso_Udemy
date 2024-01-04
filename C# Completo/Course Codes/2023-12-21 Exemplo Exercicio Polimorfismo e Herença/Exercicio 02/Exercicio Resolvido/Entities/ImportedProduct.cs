using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Entities
{
    class ImportedProduct : Produtc
    {
        public double CustoomsFee { get; set; }
        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double custoomsFee) : base (name, price)
        {
            CustoomsFee = custoomsFee;
        }
        public double totalPrice()
        {
            return Price + CustoomsFee;
        }
        public override string priceTag()
        {
            string formatting = Name + " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                +" (Customs fee: $ "+ CustoomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
            return formatting;
        }
    }
}
