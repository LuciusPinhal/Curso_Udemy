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
            PrintNeighbor(mat, i, y - 1, "Left", cols);
            PrintNeighbor(mat, i, y + 1, "Right", cols);
            PrintNeighbor(mat, i - 1, y, "Top", rows);
            PrintNeighbor(mat, i + 1, y, "Down", rows);

        }

    }
}


static void PrintNeighbor(int[,] mat, int row, int col, string direction, int limit)
{
    if (row >= 0 && row < limit && col >= 0)
    {
        Console.WriteLine($"{direction}: {mat[row, col]}");
    }
}