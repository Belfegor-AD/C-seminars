// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


using System.Runtime.Serialization.Formatters;

void FillMatrix(int[,] matrix, int[] range)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(range[0], range[1]);
        }
    }
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SwapRows(int[,] matrix)
{
    int[] tempArray = new int[matrix.GetLength(1)];
    for (int i = 0, j = 0; j < matrix.GetLength(1); j++)
    {
        tempArray[j] = matrix[i, j];
    }
}

Console.Clear();
int[,] matrix = new int[5, 10]; //размер двумерного массива
int[] rangeNumbers = {0, 50}; //диапазон значений в массиве
FillMatrix(matrix, rangeNumbers);
Console.WriteLine("Изначальный массив:");
PrintMatrix(matrix);