using System;
using System.Globalization;

namespace curso
{
    class Calculadora
    {
        public double PI = 3.14;

        public double Circunferencia(double r)
        {
            return 2 * PI * r;
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * PI * r * r * r;
        }
    }
}
