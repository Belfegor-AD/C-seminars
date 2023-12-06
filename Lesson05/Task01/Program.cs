// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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

void FindToMatrix(int[,] matrix, int[] element)
{
    if (element[0] >= matrix.GetLength(0) || element[1] >= matrix.GetLength(1))
    {
        Console.WriteLine("В матрице нет такого элемента");
    }
    else
    {
        Console.WriteLine($"Искомый элемент имеет значение: {matrix[element[0], element[1]]}");
    }    
}

Console.Clear();
int[,] matrix = new int[5, 10]; //размер двумерного массива
int[] rangeNumbers = {0, 50}; //диапазон значений в массиве
FillMatrix(matrix, rangeNumbers);
PrintMatrix(matrix);
Console.Write("Введите значения позиции искомого элемента через пробел: ");
int[] findElement = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
FindToMatrix(matrix, findElement);