// Создать массив из цифр числа

int[] ConvertNumberToArray(int num, int leng)
{
    int[] arr = new int[leng];
    for (int i = leng - 1; i >= 0; i--)
    {
        arr[i] = num % 10;
        num = num / 10;
    }
    return arr;
}


int LengthOfNumber(int num)
{
    int i = 0;
    while (num > 0)
    {
        i++;
        num /= 10;
    }
    return i;
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
int number = new Random().Next(1, 100000);
int lenght = LengthOfNumber(number);
int[] array = ConvertNumberToArray(number, lenght);
Console.WriteLine("Заланное число:" + number);
Console.WriteLine("Длина числа: " + lenght);
PrintArray(array);
