// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Enter num row matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter num columns matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter num in matrix: ");
int number = Convert.ToInt32(Console.ReadLine());



void Matrix (int[,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,21);
        }
    }

}

void PrintMatrix(int[,] matr)
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

bool ElInMatrix(int[,] matr, int num)
{   
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == num)
            {
                Console.Write($"This number is in the Matrix " + i + "; " + j);
                return true;
            }
        }
    }
    Console.Write($"This number isn't in the Matrix");
    return false;
    
    
}


int[,] matrix = new int [m , n];
Console.WriteLine($"Matrix: ");
Matrix(matrix);
PrintMatrix(matrix);
ElInMatrix(matrix, number);

