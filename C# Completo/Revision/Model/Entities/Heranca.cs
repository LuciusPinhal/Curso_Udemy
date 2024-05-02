using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Model.Entities
{
    class Heranca
    {
        protected string _nome { private get; set; } 

        private string _password { get; set; } = string.Empty;

        public Heranca() { }
        protected Heranca(string nome, string password)
        {
            _nome = nome;
            _password = password;
        }

        public void AddItens(string nome, string senha)
        {
            if (senha == null || string.IsNullOrWhiteSpace(senha))
            {
                throw new ArgumentNullException(nameof(senha), "Senha nao pode ser nula.");
            }

            _nome = nome;
            _password = senha;


        }

        public override string ToString()
        {
            return "Nome: " + _nome + " senha: " + _password;
        }
    }
}
