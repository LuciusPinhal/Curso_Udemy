using System;
using System.Collections.Generic;
using System.Globalization;

string[] n = Console.ReadLine().Split(' ');

int rows = int.Parse(n[0]);
int cols = int.Parse(n[1]);

int[,] mat = new int[rows, cols];


//percorer linhas
for (int i = 0; i < rows; i++)
{
    //separar por espaço em branco
    string[] values = Console.ReadLine().Split(' ');
    //percorrer colunas
    for (int y = 0; y < cols; y++)
    {
        mat[i, y] = int.Parse(values[y]);
    }
}
Console.WriteLine();
Console.WriteLine("Digite o numero que deseja encontrar: ");
int number = int.Parse(Console.ReadLine());


for (int i = 0; i < rows; i++)
{
    for (int y = 0; y < cols; y++)
    {
        if (mat[i, y] == number)
        {
            Console.WriteLine();
            Console.WriteLine($"Position {i},{y}");

            if (y - 1 >= 0)
            {
                Console.WriteLine($"Left: {mat[i, y - 1]}");
            }
            if (y + 1 < cols)
            {
                Console.WriteLine($"Right: {mat[i, y + 1]}");
            }
            if (i - 1 >= 0)
            {
                Console.WriteLine($"Top: {mat[i - 1, y]}");
            }
            if (i + 1 < cols)
            {
                Console.WriteLine($"Down: {mat[i + 1, y]}");
            }

        }


    }
}
