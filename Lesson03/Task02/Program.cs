﻿// Количество чётных элементов в массиве.

int[] CreateArray(int size, int begin, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end);
    }
    return array;
}

int FindInArray(int[] fullArray)
{
    int count = 0;
    foreach (int item in fullArray)
    {
        if (item % 2 == 0)
            count++;
    }
    return count;
}

void PrintArray(int[] fullArray)
{
    Console.Write($"Массив чисел: ");
    foreach (int item in fullArray)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

Console.Clear();
int sizeArray = 10;
int beginRangeArray = 1, endRangeArray = 100;
int[] array = CreateArray(sizeArray, beginRangeArray, endRangeArray);
PrintArray(array);
Console.Write($"Количество чётных элементов в массиве: " + FindInArray(array));
