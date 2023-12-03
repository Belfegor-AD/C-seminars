// Разность между макс. и мин. значением массива.

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

double FindMaxInArray(double[] fullArray)
{
    double max = fullArray[0];
    foreach (double item in fullArray)
    {
        if (item > max)
            max = item;
    }

    return max;
}

double FindMinInArray(double[] fullArray)
{
    double min = fullArray[0];
    foreach (double item in fullArray)
    {
        if (item < min)
            min = item;
    }

    return min;
}

void PrintArray(double[] fullArray)
{
    Console.Write($"Массив чисел: ");
    foreach (double item in fullArray)
    {
        Console.Write($"{item:f3}  ");
    }
    Console.WriteLine();
}

Console.Clear();
int sizeArray = 10;
double[] array = CreateArray(sizeArray);
double maxValue = FindMaxInArray(array);
double minValue = FindMinInArray(array);
PrintArray(array);
Console.Write($"Разность макс. и мин. значения массива: {maxValue:f3} - {minValue:f3} = {(maxValue - minValue):f3}");
