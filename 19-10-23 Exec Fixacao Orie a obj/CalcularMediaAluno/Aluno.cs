using System;
using System.Globalization;

namespace curso
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularNota()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool VerificarAprovado()
        {
            if (CalcularNota() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double NotaRestante()
        {
            return 60 - CalcularNota();
        }
    }
}
