int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
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

int FindInArray(int[] fullArray, int beginRange, int endRange)
{
    int count = 0;
    foreach (int item in fullArray)
    {
        if (item >= beginRange && item <= endRange)
            count++;
    }
    return count;
}

Console.Clear();
int sizeArray = 10;
int beginRange = 20, endRange = 90;
int[] array = CreateArray(sizeArray);
PrintArray(array);
Console.WriteLine();
Console.Write($"Количество элементов в диапазоне [{beginRange},{endRange}]: " + FindInArray(array, beginRange, endRange));