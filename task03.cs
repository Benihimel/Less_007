// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Enter num row matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter num columns matrix: ");
int m = Convert.ToInt32(Console.ReadLine());


void Matrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)        
        {
            matr[i, j] = new Random().Next(0,10);
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


double [] ArithmeticMeanColumns(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            result[j] += Convert.ToDouble(arr[i, j]);
        
        }
    }
    for (int i = 0; i < result.Length; i++)
    {
       result[i] /= arr.GetLength(0);
    }           
    return result;      
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}



int[,] matrix = new int [m , n];
Console.WriteLine($"Matrix: ");
Matrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Array: ");
double[] arr = ArithmeticMeanColumns(matrix);
PrintArray(arr);

