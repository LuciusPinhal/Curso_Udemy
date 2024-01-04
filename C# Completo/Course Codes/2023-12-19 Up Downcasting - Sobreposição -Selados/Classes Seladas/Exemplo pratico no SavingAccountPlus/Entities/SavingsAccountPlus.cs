using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Entities
{
    //proteção de regra de negocio
    class savingsaccountplus : savingsaccount
    {

        //também o exemplo do metodo
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);

        }
    }
}
