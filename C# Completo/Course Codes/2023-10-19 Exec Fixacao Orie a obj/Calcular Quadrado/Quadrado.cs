using System;
using System.Globalization;

namespace curso
{
    class Retangulo
    {
        public double Altura;
        public double Largura;


        public double CalcularArea()
        {
            return Altura * Largura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}
