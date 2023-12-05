// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size, int begin, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end);
    }
    return array;
}

int FindInArray(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
            count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write($"Массив чисел: ");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int[] array = CreateArray(10, 100, 999); //Создание массива из 10 значений в диапазоне [100,999]
PrintArray(array);
Console.WriteLine($"Чётных чисел: {FindInArray(array)}");