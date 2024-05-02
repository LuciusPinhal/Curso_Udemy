using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Model.Entities
{
    class Filho : Heranca
    {
        public string descricao { get; set; }

        public Filho(string nome, string password, string descricao) : base(nome, password)
        {
            this.descricao = descricao;
        }



        public override string ToString()
        {
            return base.ToString() + " Descricao " + descricao;
        }
    }
}
