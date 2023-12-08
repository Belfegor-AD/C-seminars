//  Задайте двумерный массив из целых чисел. Напишите программу, 
//  которая удалит строку и столбец, на пересечении которых 
//  расположен наименьший элемент массива. Под удалением понимается 
//  создание нового двумерного массива без строки и столбца


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

int[,] FinderMinRow(int[,] matrix)
{
    int[] indexMin = new int[2];
    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexMin[0] = i;
                indexMin[1] = j;
            }
        }
    }
    Console.WriteLine($"Позиция минимального элемента: {indexMin[0]}, {indexMin[1]}");
    
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int newRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != indexMin[0])
        {
            int newCol = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != indexMin[1])
                {
                    newMatrix[newRow, newCol] = matrix[i, j];
                    newCol++;
                }
                
            }
            newRow++;
        }
    }
    return newMatrix;
}


Console.Clear();
int[,] matrix = new int[5, 10]; //размер двумерного массива
int[] rangeNumbers = {0, 50}; //диапазон значений в массиве
FillMatrix(matrix, rangeNumbers);
Console.WriteLine("Изначальный массив:");
PrintMatrix(matrix);
Console.WriteLine($"Новый массив: ");
int[,] newMatr = FinderMinRow(matrix);
PrintMatrix(newMatr);