using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            //percorer linhas
            for (int i = 0; i < n; i++)
            {
                //separar por espaço em branco
                string[] values = Console.ReadLine().Split(' ');
                //percorrer colunas
                for (int y = 0; y < n; y++)
                {
                    mat[i, y] = int.Parse(values[y]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Main Diagonal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (mat[i, y] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative Numbers: " + count);
        }

    }
}
