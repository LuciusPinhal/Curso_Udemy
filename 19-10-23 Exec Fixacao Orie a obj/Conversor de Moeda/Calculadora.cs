using System;
using System.Globalization;

namespace curso
{
    class Calculadora
    {
        public static double IOF = 6;

        public static double ConversorDeMoeda(double d, double qtd)
        {
            double porcentagem = (d * qtd) * (IOF / 100);
            return (d * qtd) + porcentagem;
        }

    }
}
