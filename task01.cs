﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.Write("Enter num column matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter num lines matrix: ");
int m = Convert.ToInt32(Console.ReadLine());

void Matrix (double[,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble() * 1000;
        }
    }

}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

double[,] matrix = new double [m , n];
Console.WriteLine($"Matrix: ");
Matrix(matrix);
PrintMatrix(matrix);
