// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.


string ConcatChars (char[,] chars)
{
    Console.Write($"Начальный массив: ");
    string result = string.Empty;
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            Console.Write($"'{chars[i, j]}' ");
            result += chars[i, j];
        }
    }
    Console.WriteLine();
    return result;
}

Console.Clear();
char[,] chars = {{'H', 'e', 'l', 'l', 'o', ' '}, {'w', 'o', 'r', 'l', 'd', '!'}};
Console.WriteLine($"Итоговая строка: {ConcatChars(chars)}");