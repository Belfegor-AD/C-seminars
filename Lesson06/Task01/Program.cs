// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.


Console.Clear();
char[,] chars = {{'H', 'e', 'l', 'l', 'o', ' '}, {'w', 'o', 'r', 'l', 'd', '!'}};
string result = string.Empty;
Console.Write($"Начальный массив: ");
for (int i = 0; i < chars.GetLength(0); i++)
{
    for (int j = 0; j < chars.GetLength(1); j++)
    {
        Console.Write($"'{chars[i, j]}' ");
        result += chars[i, j];
    }
}
Console.WriteLine();
Console.WriteLine($"Итоговая строка: {result}");