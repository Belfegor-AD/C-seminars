// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


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

int FinderMinRow(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];
    int min = int.MaxValue;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i, j];
        }
        Console.WriteLine(sumRow[i]);
    }
    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[i] < min)
        {
            min = sumRow[i];
            minRow = i;
        }
    }
    return minRow;     
    
}


Console.Clear();
int[,] matrix = new int[5, 10]; //размер двумерного массива
int[] rangeNumbers = {0, 50}; //диапазон значений в массиве
FillMatrix(matrix, rangeNumbers);
Console.WriteLine("Изначальный массив:");
PrintMatrix(matrix);
Console.WriteLine($"Строка с минимальной суммой: {FinderMinRow(matrix)}");