using System;
using System.Globalization;

namespace curso
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public void AumentarSalario(double aumento)
        {
            SalarioBruto += SalarioBruto * (aumento / 100);
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public override string ToString()
        {
            return "Funcionario: " + Nome
                 + ", Salario: $"
                 + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
