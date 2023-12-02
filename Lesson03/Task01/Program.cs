// Количество элементов массива, значения которых лежат в отрезке.

int[] CreateArray(int size, int beginRangeArray, int endRangeArray)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(beginRangeArray, endRangeArray);
    }
    return array;
}

void PrintArray(int[] fullArray)
{
    Console.Write($"Массив чисел: ");
    foreach (int item in fullArray)
    {
        Console.Write(item + " ");
    }
}

int FindInArray(int[] fullArray, int beginRangeFinde, int endRangeFinde)
{
    int count = 0;
    foreach (int item in fullArray)
    {
        if (item >= beginRangeFinde && item <= endRangeFinde)
            count++;
    }
    return count;
}

Console.Clear();
int sizeArray = 10;
int beginRangeArray = 1, endRangeArray = 100;
int beginRangeFinde = 20, endRangeFinde = 90;
int[] array = CreateArray(sizeArray, beginRangeArray, endRangeArray);
PrintArray(array);
Console.WriteLine();
Console.Write($"Количество элементов в диапазоне [{beginRangeFinde},{endRangeFinde}]: " + FindInArray(array, beginRangeFinde, endRangeFinde));
