// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int size, int begin, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end);
    }
    return array;
}

void Flipping(int[] arr)
{
    for (int i = 0; i <= arr.Length/2; i++)
    {
        int j = arr.Length - 1 - i;
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
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

Console.Clear();
int[] array = CreateArray(10, 0, 50); //Создание массива из 10 значений в диапазоне [0,50]
PrintArray(array);
Flipping(array);
PrintArray(array);