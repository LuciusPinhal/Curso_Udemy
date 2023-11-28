using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz 

            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);
            //dimençao 0 da matriz tem 2 posicoes
            Console.WriteLine(mat.GetLength(0));
            // dimençao 2 tem posicao 3 
            Console.WriteLine(mat.GetLength(1));

        }

    }
}
