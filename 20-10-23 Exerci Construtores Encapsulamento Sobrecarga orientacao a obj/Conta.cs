using System;
using System.Globalization;

namespace curso
{
    class Conta
    {
        public int Numero { get; private set; }

        private string _Titular;
        public double Saldo { get; private set; }
        public Conta(int numero, string nome)
        {
            Numero = numero;
            _Titular = nome;
        }

        public string Nome
        {
            get { return _Titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _Titular = value;

                }
            }
        }

        public void DepositoConta(double s)
        {
            Saldo += s;
        }
        public void SaqueConta(double s)
        {
            double taxa = 5.0;
            Saldo -= (s + taxa);
        }


        public void VerificaDeposito(string Deposito)
        {
            if (Deposito == "s" || Deposito == "S")
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                Saldo = double.Parse(Console.ReadLine());
            }

        }

        public override string ToString()
        {
            return "Conta: " + Numero
                + ", Títular: "
                + Nome
                + ", Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
